using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//BREEDING TABLE NEEDS TO BE NORMALIZED***
namespace DexDatabase
{
	public partial class MainPage : Form
	{
        string connectionString;
        SqlConnection cnn;
		//int offSet = 0; //this will mark the increment of 10 (or 5 in early development) that the main page is currently on. changed by arrow keys
        public MainPage()
		{
			InitializeComponent();
			connectionString = "Data Source=SILVER;Initial Catalog=Pokedex_Proto;Integrated Security=True";
			cnn = new SqlConnection(connectionString);
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\001.png");
            loadDexEntries();
            loadCurrentEntry(dexNoPlaceHolder1.Text);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void WelcomeLabel_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void dexEntryPlaceholder1_Click(object sender, EventArgs e)
        {
            if (File.Exists($"..\\..\\{dexNoPlaceHolder1.Text}.png"))
                pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder1.Text}.png"); //EX:Project Dir/001.png
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\000.png");
            loadCurrentEntry(dexNoPlaceHolder1.Text);

        }

        private void dexEntryPlaceholder2_Click(object sender, EventArgs e) //make a function for this query so each click trigger can call that to avoid repetitions
        {
            if (File.Exists($"..\\..\\{dexNoPlaceHolder2.Text}.png")) //update image to selected entry on click, missing no if no image
                pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder2.Text}.png");
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\000.png");
            loadCurrentEntry(dexNoPlaceHolder2.Text);
        }

        private void dexEntryPlaceholder3_Click(object sender, EventArgs e)
        {
            if(File.Exists($"..\\..\\{dexNoPlaceHolder3.Text}.png"))
                pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder3.Text}.png");
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\000.png");
        }
        private void dexEntryPlaceholder4_Click(object sender, EventArgs e)
        {
            if (File.Exists($"..\\..\\{dexNoPlaceHolder4.Text}.png"))
                pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder4.Text}.png");
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\000.png");
        }
        private void dexEntryPlaceholder5_Click(object sender, EventArgs e)
        {
            if (File.Exists($"..\\..\\{dexNoPlaceHolder5.Text}.png"))
                pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder5.Text}.png");
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\000.png");
        }




        private void loadDexEntries()
		{

			cnn.Open();

            SqlCommand cmdLoadDexEntries = cnn.CreateCommand();
            cmdLoadDexEntries.CommandText = "SELECT dexNo, pokeName FROM POKEMON";
            SqlDataReader dexReader = cmdLoadDexEntries.ExecuteReader();


			//find a way to loop through this and a way to always be 3 digits
			dexReader.Read();
            dexNoPlaceHolder1.Text = dexReader[0].ToString().PadLeft(3, '0');
			namePlaceholder1.Text = dexReader[1].ToString();
            dexReader.Read();
            dexNoPlaceHolder2.Text = dexReader[0].ToString().PadLeft(3, '0');
            namePlaceholder2.Text = dexReader[1].ToString();
            dexReader.Read();
            dexNoPlaceHolder3.Text = dexReader[0].ToString().PadLeft(3, '0');
            namePlaceholder3.Text = dexReader[1].ToString();
            dexReader.Read();
            dexNoPlaceHolder4.Text = dexReader[0].ToString().PadLeft(3, '0');
            namePlaceholder4.Text = dexReader[1].ToString();
            dexReader.Read();
            dexNoPlaceHolder5.Text = dexReader[0].ToString().PadLeft(3, '0');
            namePlaceholder5.Text = dexReader[1].ToString();

            dexReader.Close();
            cnn.Close();
        }


        private void loadCurrentEntry(string dexNo)
        {
            //update text for all other displayed information
            //dexno, type, species, height, weight, abilities
            // open sql connection for queries
            cnn.Open();

            //split from just one query due to multiple entries per 1 dexno in hasability and pokemon type
            /*wouldve been SELECT Species, Height, Weight, Ability, Type
            FROM POKEMON JOIN [POKEMON TYPE] ON dexNo = [POKEMON TYPE].dexNumber JOIN [HAS ABILITY] ON dexNo = [HAS ABILITY].dexNumber*/

            //query for species height weight
            currentDexNo.Text = dexNoPlaceHolder2.Text;
            SqlCommand cmdLoadMainDexData = cnn.CreateCommand();
            cmdLoadMainDexData.CommandText = $"SELECT Species, Height, Weight, Type\r\nFROM POKEMON \r\nWHERE dexNo ={dexNo} ";
            SqlDataReader dexReader = cmdLoadMainDexData.ExecuteReader();

            //store dexno species height weight in gui
            currentDexNo.Text = dexNo;
            dexReader.Read(); 
            currentSpecies.Text = dexReader[0].ToString();
            currentHeight.Text= dexReader[1].ToString();
            currentWeight.Text= dexReader[2].ToString();
            pokeType1.Text= dexReader[3].ToString();
            dexReader.Close();

            //query for secondary type and store in gui
            cmdLoadMainDexData.CommandText = $"SELECT type2\r\nFROM SECONDARY_TYPE\r\nWHERE dexNumber = {dexNo} ";
            dexReader = cmdLoadMainDexData.ExecuteReader();
            if (dexReader.Read())
                pokeType2.Text = dexReader[0].ToString();
            dexReader.Close();

            //query for abilities and store in gui
            //set all ability labels to empty
            pokeAbility1.Text = "";
            pokeAbility2.Text = "";
            pokeAbilityHidden.Text = "";
            cmdLoadMainDexData.CommandText = $"SELECT Ability, abilityIndex\r\nFROM [HAS ABILITY]\r\nWHERE dexNumber = {dexNo} ";
            dexReader = cmdLoadMainDexData.ExecuteReader();
            while (dexReader.Read())
            {
                switch (dexReader[1])
                {
                    case 0:
                        pokeAbility1.Text = dexReader[0].ToString();
                        break;
                    case 1:
                        pokeAbility2.Text = dexReader[0].ToString();
                        break;
                    case 2:
                        pokeAbilityHidden.Text = dexReader[0].ToString();
                        break;
                    default:
                        break;
                }
            }
            dexReader.Close();


            //close connection
            cnn.Close() ;
        }

        private void loadCurrentEntryExtended() // for extended view in the future
        {

        }
    }
}
