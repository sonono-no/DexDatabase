﻿using System;
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
	public partial class MainPage : Form
	{
        string connectionString;
        SqlConnection cnn;
		int offSet = 0; //this will mark the increment of 10 (or 5 in early development) that the main page is currently on. changed by arrow keys
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


        //add exception for image fetch for on the offchance that all entries are not populated / the image doesn't exist
        private void dexEntryPlaceholder1_Click(object sender, EventArgs e)
        {
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder1.Text}.png"); //EX:Project Dir/001.png
            
        }

        private void dexEntryPlaceholder2_Click(object sender, EventArgs e)
        { 
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder2.Text}.png");
        }

        private void dexEntryPlaceholder3_Click(object sender, EventArgs e)
        {
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder3.Text}.png");
        }
        private void dexEntryPlaceholder4_Click(object sender, EventArgs e)
        {
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder4.Text}.png");
        }
        private void dexEntryPlaceholder5_Click(object sender, EventArgs e)
        {
            pokePicture.BackgroundImage = Image.FromFile($"..\\..\\{dexNoPlaceHolder5.Text}.png");
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
    }
}
