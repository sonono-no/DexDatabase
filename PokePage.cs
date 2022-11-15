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

namespace DexDatabase
{
	public partial class PokePage : Form
	{
		string dexNo;
        string connectionString;
        SqlConnection cnn;
        public PokePage()
		{
			InitializeComponent();
        }


        public void UpdateInfo(string dexNum)
        {
            connectionString = "Data Source=SILVER;Initial Catalog=Pokedex_Proto;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            dexNo = dexNum;
            if (dexNo == "???")// probably just change the entire current dex entry display to a questionmark
            {
                loadCurrentDexSprite("000");
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
            else if (dexNo == "---")
            {
                loadCurrentDexSprite("000");
                currentDexNo.Text = "---";
                currentSpecies.Text = null;
                currentHeight.Text = null;
                currentWeight.Text = null;
                pokeType1.Text = null;
                pokeType2.Text = null;
                pokeAbility1.Text = null;
                pokeAbility2.Text = null;
                pokeAbilityHidden.Text = null;
            }
            else
            {
                loadCurrentDexSprite(dexNo);
                //update text for all other displayed information
                //dexno, type, species, height, weight, abilities
                // open sql connection for queries
                cnn.Open();

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
                {
                    pokeType2.Text = dexReader[0].ToString();
                }
                else
                    pokeType2.Text = null;
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
                // add code to fill extended view with current info

                //base stats query
                cmdLoadMainDexData.CommandText = $"SELECT *\r\nFROM [BASE STATS]\r\nWHERE dexNumber = {dexNo} ";
                dexReader = cmdLoadMainDexData.ExecuteReader();
                dexReader.Read();
                PokeBaseStats.Text = null;
                for(int i = 1; i < 7; i++)
                {
                    PokeBaseStats.Text += dexReader[i].ToString().PadLeft(10, ' ');
                }
                dexReader.Close();



                //egg groups query

                cmdLoadMainDexData.CommandText = $"SELECT eggGroup, eggGroup2, eggCycles\r\nFROM BREEDING JOIN SECONDARY_POKE_EGG_GROUP on BREEDING.dexNumber=SECONDARY_POKE_EGG_GROUP.dexNumber\r\nWHERE BREEDING.dexNumber = {dexNo} ";
                dexReader = cmdLoadMainDexData.ExecuteReader();
                dexReader.Read();
                eggGroup1.Text = dexReader[0].ToString() + "/";
                eggGroup2.Text = dexReader[1].ToString();
                eggCycles.Text = dexReader[2].ToString();
                dexReader.Close();


                //gender query
                cmdLoadMainDexData.CommandText = $"SELECT gender, occurrancePercentage\r\nFROM GENDER_FREQUENCY\r\nWHERE dexNumber = {dexNo} ";
                dexReader = cmdLoadMainDexData.ExecuteReader();
                genderRatio1.Text = null;
                genderRatio2.Text = null;
                while(dexReader.Read())
                {
                    switch(dexReader[0].ToString())
                    {
                        case "False":
                            genderRatio1.Text = dexReader[1].ToString();
                            break;
                        case "True":
                            genderRatio2.Text = dexReader[1].ToString();
                            break;
                    }
                }
                dexReader.Close();


                //type effectiveness query
                /*                cmdLoadMainDexData.CommandText = $"SELECT *\r\nFROM TYPE\r\nWHERE currentType = {pokeType1} OR currentType = {pokeType2}";
                                dexReader = cmdLoadMainDexData.ExecuteReader();

                                fullType1Placeholder.Text = null;
                                fullType2Placeholder.Text = null;


                                dexReader.Read();
                                for(int i = 1; i < 17; i++)
                                {
                                    fullType1Placeholder.Text += dexReader[i].ToString();
                                }

                                fullType1Placeholder.Text = dexReader[0].ToString();

                                dexReader.Close();*/

                //evolutions query
                cmdLoadMainDexData.CommandText = $"SELECT isPrevious, Evolution\r\nFROM Evolution\r\nWHERE dexNumber = {dexNo} ";
                dexReader = cmdLoadMainDexData.ExecuteReader();
                Evo1.Text = null;
                Evo2.Text = null;
                while(dexReader.Read())
                {
                    switch(dexReader[0].ToString())
                    {
                        case "False":
                            Evo2.Text = "Next Evolution: " + dexReader[1].ToString();
                            break;
                        case "True":
                            Evo1.Text = "Previous Evolution: " + dexReader[1].ToString();
                            break;
                    }
                }
                dexReader.Close();



                //close connection
                cnn.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
		{

		}



        private void loadCurrentDexSprite(string dexNo) //isSearch will determine whether empty entries will be continuously displayed or not
        {
            if (Int32.TryParse(dexNo, out int tryDexNo))
            {
                if (File.Exists($"..\\..\\images\\{Int32.Parse(dexNo)}.png"))
                    pokePicture.BackgroundImage = Image.FromFile($"..\\..\\images\\{Int32.Parse(dexNo)}.png");
                else
                    pokePicture.BackgroundImage = Image.FromFile("..\\..\\images\\000.png");
            }
            else
                pokePicture.BackgroundImage = Image.FromFile("..\\..\\images\\000.png");
        }
        }
}
