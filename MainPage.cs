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

// on MainPage.Designer.cs, do overloads for click trigger on all members on dexEntryPlaceholder panels. EX: this.namePlaceholder1.Click += new System.EventHandler(this.dexEntryPlaceholder1_Click);
// otherwise clicking on the label instead of the panel will not trigger the load
namespace DexDatabase
{
	public partial class MainPage : Form
	{
        string connectionString;
        SqlConnection cnn;
		int offSet = 1; //this will mark the increment of 10 (or 5 in early development) that the main page is currently on. changed by arrow keys
        public MainPage()
		{
			InitializeComponent();
			connectionString = "Data Source=SILVER;Initial Catalog=Pokedex_Proto;Integrated Security=True";
			cnn = new SqlConnection(connectionString);
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\001.png");
            loadDexEntries();
            
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
            loadCurrentDexSprite(dexNoPlaceHolder1.Text);
            loadCurrentEntry(dexNoPlaceHolder1.Text);

        }

        private void dexEntryPlaceholder2_Click(object sender, EventArgs e)
        {
            loadCurrentDexSprite(dexNoPlaceHolder2.Text);
            loadCurrentEntry(dexNoPlaceHolder2.Text);
        }

        private void dexEntryPlaceholder3_Click(object sender, EventArgs e)
        {
            loadCurrentDexSprite(dexNoPlaceHolder3.Text);
            loadCurrentEntry(dexNoPlaceHolder3.Text);
        }
        private void dexEntryPlaceholder4_Click(object sender, EventArgs e)
        {
            loadCurrentDexSprite(dexNoPlaceHolder4.Text);
            loadCurrentEntry(dexNoPlaceHolder4.Text);
        }
        private void dexEntryPlaceholder5_Click(object sender, EventArgs e)
        {
            loadCurrentDexSprite(dexNoPlaceHolder5.Text);
            loadCurrentEntry(dexNoPlaceHolder5.Text);
        }


        private void loadCurrentDexSprite(string dexNo)
        {
            if (File.Exists($"..\\..\\{dexNo}.png"))
                pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNo}.png");
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\000.png");
        }

        private void loadDexEntries()
		{
            
			cnn.Open();

            SqlCommand cmdLoadDexEntries = cnn.CreateCommand();
            cmdLoadDexEntries.CommandText = $"SELECT dexNo, pokeName FROM POKEMON WHERE dexNo > {offSet*5}"; //change to adapt to current offset
            SqlDataReader dexReader = cmdLoadDexEntries.ExecuteReader();

            var placeholderLabels = new List<Label> { dexNoPlaceHolder1, namePlaceholder1, dexNoPlaceHolder2, namePlaceholder2, dexNoPlaceHolder3, namePlaceholder3, dexNoPlaceHolder4, namePlaceholder4,  dexNoPlaceHolder5, namePlaceholder5 };

            for(int i = 0; i < 10; i = i+2)
            {
                if (dexReader.Read())
                {
                    placeholderLabels[i].Text = dexReader[0].ToString().PadLeft(3, '0');
                    placeholderLabels[i + 1].Text = dexReader[1].ToString();
                }
                else
                { //this else section is pretty sloppy
                    placeholderLabels[i].Text = $"{offSet*5 + (i+2)/2}".PadLeft(3, '0');
                    placeholderLabels[i + 1].Text = "???";
                }
            }
            loadCurrentDexSprite(dexNoPlaceHolder1.Text);
            dexReader.Close();
            cnn.Close();
            loadCurrentEntry(dexNoPlaceHolder1.Text);
        }


        private void loadCurrentEntry(string dexNo) //now add for case where there isn't a valid current entry
        {
            if (namePlaceholder1.Text == "???")// probably just change the entire current dex entry display to a questionmark
            {
                currentDexNo.Text = "???";
                currentSpecies.Text = "Undiscovered";
                currentHeight.Text = "Undiscovered";
                currentWeight.Text = "Undiscovered";
                pokeType1.Text = "Undiscovered";
                pokeType2.Text = "Undiscovered";
                pokeAbility1.Text = "Undiscovered";
                pokeAbility2.Text = null;
                pokeAbilityHidden.Text = null;

            }
            else
            {
                //update text for all other displayed information
                //dexno, type, species, height, weight, abilities
                // open sql connection for queries
                cnn.Open();

                //split from just one query due to multiple entries per 1 dexno in hasability and pokemon type
                /*wouldve been SELECT Species, Height, Weight, Ability, Type
                FROM POKEMON JOIN [POKEMON TYPE] ON dexNo = [POKEMON TYPE].dexNumber JOIN [HAS ABILITY] ON dexNo = [HAS ABILITY].dexNumber*/

                //query for species height weight
                SqlCommand cmdLoadMainDexData = cnn.CreateCommand();
                cmdLoadMainDexData.CommandText = $"SELECT Species, Height, Weight, Type\r\nFROM POKEMON \r\nWHERE dexNo ={dexNo} ";
                SqlDataReader dexReader = cmdLoadMainDexData.ExecuteReader();

                //store dexno species height weight in gui
                currentDexNo.Text = dexNo;
                dexReader.Read();
                currentSpecies.Text = dexReader[0].ToString();
                currentHeight.Text = dexReader[1].ToString();
                currentWeight.Text = dexReader[2].ToString();
                pokeType1.Text = dexReader[3].ToString();
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
                cnn.Close();
            }
        }

        private void loadCurrentEntryExtended() // for extended view in the future
        {

        }

        private void testUpButton_Click(object sender, EventArgs e)
        {
            if(offSet > 0)
            {
                offSet--;
                loadDexEntries();
            }
        }

        private void testDownButton_Click(object sender, EventArgs e)
        {
            offSet++;
            loadDexEntries();
        }
    }
}
