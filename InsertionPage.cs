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

namespace DexDatabase
{
	public partial class InsertionPage : Form
	{
        SqlConnection cnn;

        public InsertionPage()
		{
			InitializeComponent();
            type2Dropdown.Items.Add("hello");
            cnn = new SqlConnection("Data Source=SILVER;Initial Catalog=Pokedex_Proto;Integrated Security=True");
            cnn.Open();
            SqlCommand cmdLoad = cnn.CreateCommand();
            SqlDataReader reader;

            //query types and load them into the drop downs for type selection
            cmdLoad.CommandText = "SELECT currentType FROM TYPE";
            reader = cmdLoad.ExecuteReader();
            while(reader.Read())
            {
                type1Dropdown.Items.Add(reader[0].ToString());
                type2Dropdown.Items.Add(reader[0].ToString());
            }
            reader.Close();
            //query abilities and add them to abilities drop downs
            cmdLoad.CommandText = "SELECT abilityName FROM ABILITY";
            reader = cmdLoad.ExecuteReader();
            while(reader.Read())
            {
                ability1Box.Items.Add(reader[0].ToString());
                ability2Box.Items.Add(reader[0].ToString());
                hiddenAbilityBox.Items.Add(reader[0].ToString());
            }
            reader.Close();
            //query egg groups and add them to drop downs
            cmdLoad.CommandText = "SELECT *\r\nFROM EGG_GROUPS";
            reader = cmdLoad.ExecuteReader();
            while(reader.Read())
            {
                breedingGroup1Input.Items.Add(reader[0].ToString());
                breedingGroup2Input.Items.Add(reader[0].ToString());
            }


            reader.Close();
            cnn.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            cnn.Open();
            SqlCommand cmdInsertEntry = cnn.CreateCommand();
            
            try
            {
                cmdInsertEntry.CommandText = $"INSERT INTO POKEMON\r\nVALUES ({NumberBox.Text}, '{PokeNameBox.Text}', '{SpeciesBox.Text}', {HeightBox.Text}, {WeightBox.Text}, '{type1Dropdown.Text}')";
                /*            cmdInsertEntry.Parameters.AddWithValue("@dexNo", NumberBox.Text);
                            cmdInsertEntry.Parameters.AddWithValue("@pokeName", PokeNameBox.Text);
                            cmdInsertEntry.Parameters.AddWithValue("@pokeSpecies", SpeciesBox.Text);
                            cmdInsertEntry.Parameters.AddWithValue("@height", HeightBox.Text);
                            cmdInsertEntry.Parameters.AddWithValue("@weight", WeightBox.Text);
                            cmdInsertEntry.Parameters.AddWithValue("@type", Type1Box);*/
                cmdInsertEntry.ExecuteNonQuery();

                cmdInsertEntry.CommandText = $"INSERT INTO SECONDARY_TYPE\r\nVALUES ({NumberBox.Text}, '{type2Dropdown.Text}')";
                cmdInsertEntry.ExecuteNonQuery();

                //insert selected abilities
                cmdInsertEntry.CommandText = $"INSERT INTO [HAS ABILITY]\r\nVALUES({NumberBox.Text}, '{ability1Box.Text}', 0)";
                cmdInsertEntry.ExecuteNonQuery();
                if (ability2Box.Text != "Insert Ability 2")
                {
                    cmdInsertEntry.CommandText = $"INSERT INTO [HAS ABILITY]\r\nVALUES({NumberBox.Text}, '{ability2Box.Text}', 1)";
                    cmdInsertEntry.ExecuteNonQuery();
                }
                if (hiddenAbilityBox.Text != "Insert Hidden Ability")
                {
                    cmdInsertEntry.CommandText = $"INSERT INTO [HAS ABILITY]\r\nVALUES({NumberBox.Text}, '{hiddenAbilityBox.Text}', 2)";
                    cmdInsertEntry.ExecuteNonQuery();
                }


                //insert base stats
                cmdInsertEntry.CommandText = $"INSERT INTO [BASE STATS]\r\nVALUES({NumberBox.Text}, {hpInputBox.Text}, {attackInputBox.Text}, {defenseInputBox.Text}, {specialAttackInputBox.Text}, {specialDefenseInputBox.Text}, {speedInputBox.Text})";
                cmdInsertEntry.ExecuteNonQuery();

                //insert egg groups
                cmdInsertEntry.CommandText = $"INSERT INTO BREEDING\r\nVALUES ({NumberBox.Text}, '{breedingGroup1Input.Text}', {eggCyclesInput.Text})";
                cmdInsertEntry.ExecuteNonQuery();
                if(breedingGroup2Input!= null) //
                {
                    cmdInsertEntry.CommandText = $"INSERT INTO SECONDARY_POKE_EGG_GROUP\r\nVALUES({NumberBox.Text}, '{breedingGroup2Input.Text}')";
                    cmdInsertEntry.ExecuteNonQuery();
                }

                //previous evolution
                if (Int32.TryParse(PrevEvoBox.Text, out int check)){
                    cmdInsertEntry.CommandText = $"INSERT INTO Evolution\r\nVALUES ({NumberBox.Text}, {PrevEvoBox.Text}, True";
                    cmdInsertEntry.ExecuteNonQuery();
                }
                //next evolution
                if (Int32.TryParse(NextEvoBox.Text, out int check2))
                {
                    cmdInsertEntry.CommandText = $"INSERT INTO Evolution\r\nVALUES ({NumberBox.Text}, {NextEvoBox.Text}, False";
                    cmdInsertEntry.ExecuteNonQuery();
                }



                System.Windows.Forms.MessageBox.Show("Insertion operation was succcessful!");
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Invalid insertion operation...");
                System.Windows.Forms.MessageBox.Show(cmdInsertEntry.CommandText.ToString());
            }

            cnn.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
