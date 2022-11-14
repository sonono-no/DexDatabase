using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DexDatabase
{
	partial class MainPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{

			this.SearchBar = new System.Windows.Forms.TextBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.DexLabel = new System.Windows.Forms.Label();
			this.WelcomeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CaughtText = new System.Windows.Forms.TextBox();
			this.SeenText = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.dexEntryPlaceholder1 = new System.Windows.Forms.Panel();
			this.dexNoPlaceHolder1 = new System.Windows.Forms.Label();
			this.namePlaceholder1 = new System.Windows.Forms.Label();
			this.testDownButton = new System.Windows.Forms.Button();
			this.testUpButton = new System.Windows.Forms.Button();
			this.dexEntryPlaceholder2 = new System.Windows.Forms.Panel();
			this.namePlaceholder2 = new System.Windows.Forms.Label();
			this.dexNoPlaceHolder2 = new System.Windows.Forms.Label();
			this.dexEntryPlaceholder5 = new System.Windows.Forms.Panel();
			this.namePlaceholder5 = new System.Windows.Forms.Label();
			this.dexNoPlaceHolder5 = new System.Windows.Forms.Label();
			this.dexEntryPlaceholder4 = new System.Windows.Forms.Panel();
			this.namePlaceholder4 = new System.Windows.Forms.Label();
			this.dexNoPlaceHolder4 = new System.Windows.Forms.Label();
			this.dexEntryPlaceholder3 = new System.Windows.Forms.Panel();
			this.namePlaceholder3 = new System.Windows.Forms.Label();
			this.dexNoPlaceHolder3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pokeAbility2 = new System.Windows.Forms.Label();
			this.pokeAbilityHidden = new System.Windows.Forms.Label();
			this.pokeAbility1 = new System.Windows.Forms.Label();
			this.currentWeight = new System.Windows.Forms.Label();
			this.currentHeight = new System.Windows.Forms.Label();
			this.currentSpecies = new System.Windows.Forms.Label();
			this.pokeType2 = new System.Windows.Forms.Label();
			this.pokeType1 = new System.Windows.Forms.Label();
			this.currentDexNo = new System.Windows.Forms.Label();
			this.abilitiesLabel = new System.Windows.Forms.Label();
			this.weightLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.speciesLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.nationalDexLabel = new System.Windows.Forms.Label();
			this.pokePicture = new System.Windows.Forms.PictureBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.dexEntryPlaceholder1.SuspendLayout();
			this.dexEntryPlaceholder2.SuspendLayout();
			this.dexEntryPlaceholder5.SuspendLayout();
			this.dexEntryPlaceholder4.SuspendLayout();
			this.dexEntryPlaceholder3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pokePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchBar
			// 
			this.SearchBar.AcceptsTab = true;
			this.SearchBar.Location = new System.Drawing.Point(259, 92);
			this.SearchBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SearchBar.Name = "SearchBar";
			this.SearchBar.Size = new System.Drawing.Size(185, 20);
			this.SearchBar.TabIndex = 0;
			this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.White;
			this.SearchButton.Location = new System.Drawing.Point(448, 91);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(57, 20);
			this.SearchButton.TabIndex = 1;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = false;
			this.SearchButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// DexLabel
			// 
			this.DexLabel.AutoSize = true;
			this.DexLabel.BackColor = System.Drawing.SystemColors.Control;
			this.DexLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DexLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DexLabel.Location = new System.Drawing.Point(330, 9);
			this.DexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DexLabel.Name = "DexLabel";
			this.DexLabel.Size = new System.Drawing.Size(99, 26);
			this.DexLabel.TabIndex = 2;
			this.DexLabel.Text = "DEX DB";
			this.DexLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// WelcomeLabel
			// 
			this.WelcomeLabel.AutoSize = true;
			this.WelcomeLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeLabel.ForeColor = System.Drawing.Color.Blue;
			this.WelcomeLabel.Location = new System.Drawing.Point(15, 15);
			this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.Size = new System.Drawing.Size(0, 19);
			this.WelcomeLabel.TabIndex = 3;
			this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(256, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pokemon Caught:";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(265, 68);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Pokemon Seen:";
			// 
			// CaughtText
			// 
			this.CaughtText.Location = new System.Drawing.Point(357, 46);
			this.CaughtText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CaughtText.Name = "CaughtText";
			this.CaughtText.ReadOnly = true;
			this.CaughtText.Size = new System.Drawing.Size(68, 20);
			this.CaughtText.TabIndex = 6;
			// 
			// SeenText
			// 
			this.SeenText.Location = new System.Drawing.Point(357, 68);
			this.SeenText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SeenText.Name = "SeenText";
			this.SeenText.ReadOnly = true;
			this.SeenText.Size = new System.Drawing.Size(68, 20);
			this.SeenText.TabIndex = 7;
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.White;
			this.AddButton.Location = new System.Drawing.Point(587, 35);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(95, 23);
			this.AddButton.TabIndex = 8;
			this.AddButton.Text = "Add Pokemon";
			this.AddButton.UseVisualStyleBackColor = false;
			// 
			// dexEntryPlaceholder1
			// 
			this.dexEntryPlaceholder1.BackColor = System.Drawing.Color.LightCoral;
			this.dexEntryPlaceholder1.Controls.Add(this.dexNoPlaceHolder1);
			this.dexEntryPlaceholder1.Controls.Add(this.namePlaceholder1);
			this.dexEntryPlaceholder1.Location = new System.Drawing.Point(18, 136);
			this.dexEntryPlaceholder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dexEntryPlaceholder1.Name = "dexEntryPlaceholder1";
			this.dexEntryPlaceholder1.Size = new System.Drawing.Size(150, 30);
			this.dexEntryPlaceholder1.TabIndex = 9;
			this.dexEntryPlaceholder1.Click += new System.EventHandler(this.dexEntryPlaceholder1_Click);
			// 
			// dexNoPlaceHolder1
			// 
			this.dexNoPlaceHolder1.AutoSize = true;
			this.dexNoPlaceHolder1.Location = new System.Drawing.Point(2, 9);
			this.dexNoPlaceHolder1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dexNoPlaceHolder1.Name = "dexNoPlaceHolder1";
			this.dexNoPlaceHolder1.Size = new System.Drawing.Size(44, 13);
			this.dexNoPlaceHolder1.TabIndex = 0;
			this.dexNoPlaceHolder1.Text = "dexNo1";
			this.dexNoPlaceHolder1.Click += new System.EventHandler(this.dexEntryPlaceholder1_Click);
			// 
			// namePlaceholder1
			// 
			this.namePlaceholder1.AutoSize = true;
			this.namePlaceholder1.Location = new System.Drawing.Point(47, 9);
			this.namePlaceholder1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.namePlaceholder1.Name = "namePlaceholder1";
			this.namePlaceholder1.Size = new System.Drawing.Size(65, 13);
			this.namePlaceholder1.TabIndex = 1;
			this.namePlaceholder1.Text = "pokeName1";
			this.namePlaceholder1.Click += new System.EventHandler(this.dexEntryPlaceholder1_Click);
			// 
			// testDownButton
			// 
			this.testDownButton.Location = new System.Drawing.Point(18, 310);
			this.testDownButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.testDownButton.Name = "testDownButton";
			this.testDownButton.Size = new System.Drawing.Size(56, 19);
			this.testDownButton.TabIndex = 14;
			this.testDownButton.Text = "⌄";
			this.testDownButton.UseVisualStyleBackColor = true;
			this.testDownButton.Click += new System.EventHandler(this.testDownButton_Click);
			// 
			// testUpButton
			// 
			this.testUpButton.Location = new System.Drawing.Point(18, 113);
			this.testUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.testUpButton.Name = "testUpButton";
			this.testUpButton.Size = new System.Drawing.Size(56, 19);
			this.testUpButton.TabIndex = 15;
			this.testUpButton.Text = "^";
			this.testUpButton.UseVisualStyleBackColor = true;
			this.testUpButton.Click += new System.EventHandler(this.testUpButton_Click);
			// 
			// dexEntryPlaceholder2
			// 
			this.dexEntryPlaceholder2.BackColor = System.Drawing.SystemColors.Control;
			this.dexEntryPlaceholder2.Controls.Add(this.namePlaceholder2);
			this.dexEntryPlaceholder2.Controls.Add(this.dexNoPlaceHolder2);
			this.dexEntryPlaceholder2.Location = new System.Drawing.Point(18, 171);
			this.dexEntryPlaceholder2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dexEntryPlaceholder2.Name = "dexEntryPlaceholder2";
			this.dexEntryPlaceholder2.Size = new System.Drawing.Size(150, 30);
			this.dexEntryPlaceholder2.TabIndex = 16;
			this.dexEntryPlaceholder2.Click += new System.EventHandler(this.dexEntryPlaceholder2_Click);
			// 
			// namePlaceholder2
			// 
			this.namePlaceholder2.AutoSize = true;
			this.namePlaceholder2.Location = new System.Drawing.Point(47, 9);
			this.namePlaceholder2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.namePlaceholder2.Name = "namePlaceholder2";
			this.namePlaceholder2.Size = new System.Drawing.Size(65, 13);
			this.namePlaceholder2.TabIndex = 1;
			this.namePlaceholder2.Text = "pokeName1";
			// 
			// dexNoPlaceHolder2
			// 
			this.dexNoPlaceHolder2.AutoSize = true;
			this.dexNoPlaceHolder2.Location = new System.Drawing.Point(2, 9);
			this.dexNoPlaceHolder2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dexNoPlaceHolder2.Name = "dexNoPlaceHolder2";
			this.dexNoPlaceHolder2.Size = new System.Drawing.Size(44, 13);
			this.dexNoPlaceHolder2.TabIndex = 0;
			this.dexNoPlaceHolder2.Text = "dexNo1";
			// 
			// dexEntryPlaceholder5
			// 
			this.dexEntryPlaceholder5.BackColor = System.Drawing.SystemColors.Control;
			this.dexEntryPlaceholder5.Controls.Add(this.namePlaceholder5);
			this.dexEntryPlaceholder5.Controls.Add(this.dexNoPlaceHolder5);
			this.dexEntryPlaceholder5.Location = new System.Drawing.Point(18, 276);
			this.dexEntryPlaceholder5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dexEntryPlaceholder5.Name = "dexEntryPlaceholder5";
			this.dexEntryPlaceholder5.Size = new System.Drawing.Size(150, 30);
			this.dexEntryPlaceholder5.TabIndex = 17;
			this.dexEntryPlaceholder5.Click += new System.EventHandler(this.dexEntryPlaceholder5_Click);
			// 
			// namePlaceholder5
			// 
			this.namePlaceholder5.AutoSize = true;
			this.namePlaceholder5.Location = new System.Drawing.Point(47, 9);
			this.namePlaceholder5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.namePlaceholder5.Name = "namePlaceholder5";
			this.namePlaceholder5.Size = new System.Drawing.Size(65, 13);
			this.namePlaceholder5.TabIndex = 1;
			this.namePlaceholder5.Text = "pokeName1";
			// 
			// dexNoPlaceHolder5
			// 
			this.dexNoPlaceHolder5.AutoSize = true;
			this.dexNoPlaceHolder5.Location = new System.Drawing.Point(2, 9);
			this.dexNoPlaceHolder5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dexNoPlaceHolder5.Name = "dexNoPlaceHolder5";
			this.dexNoPlaceHolder5.Size = new System.Drawing.Size(44, 13);
			this.dexNoPlaceHolder5.TabIndex = 0;
			this.dexNoPlaceHolder5.Text = "dexNo1";
			// 
			// dexEntryPlaceholder4
			// 
			this.dexEntryPlaceholder4.BackColor = System.Drawing.SystemColors.Control;
			this.dexEntryPlaceholder4.Controls.Add(this.namePlaceholder4);
			this.dexEntryPlaceholder4.Controls.Add(this.dexNoPlaceHolder4);
			this.dexEntryPlaceholder4.Location = new System.Drawing.Point(18, 241);
			this.dexEntryPlaceholder4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dexEntryPlaceholder4.Name = "dexEntryPlaceholder4";
			this.dexEntryPlaceholder4.Size = new System.Drawing.Size(150, 30);
			this.dexEntryPlaceholder4.TabIndex = 18;
			this.dexEntryPlaceholder4.Click += new System.EventHandler(this.dexEntryPlaceholder4_Click);
			// 
			// namePlaceholder4
			// 
			this.namePlaceholder4.AutoSize = true;
			this.namePlaceholder4.Location = new System.Drawing.Point(47, 9);
			this.namePlaceholder4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.namePlaceholder4.Name = "namePlaceholder4";
			this.namePlaceholder4.Size = new System.Drawing.Size(65, 13);
			this.namePlaceholder4.TabIndex = 1;
			this.namePlaceholder4.Text = "pokeName1";
			// 
			// dexNoPlaceHolder4
			// 
			this.dexNoPlaceHolder4.AutoSize = true;
			this.dexNoPlaceHolder4.Location = new System.Drawing.Point(2, 9);
			this.dexNoPlaceHolder4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dexNoPlaceHolder4.Name = "dexNoPlaceHolder4";
			this.dexNoPlaceHolder4.Size = new System.Drawing.Size(44, 13);
			this.dexNoPlaceHolder4.TabIndex = 0;
			this.dexNoPlaceHolder4.Text = "dexNo1";
			// 
			// dexEntryPlaceholder3
			// 
			this.dexEntryPlaceholder3.BackColor = System.Drawing.SystemColors.Control;
			this.dexEntryPlaceholder3.Controls.Add(this.namePlaceholder3);
			this.dexEntryPlaceholder3.Controls.Add(this.dexNoPlaceHolder3);
			this.dexEntryPlaceholder3.Location = new System.Drawing.Point(18, 206);
			this.dexEntryPlaceholder3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dexEntryPlaceholder3.Name = "dexEntryPlaceholder3";
			this.dexEntryPlaceholder3.Size = new System.Drawing.Size(150, 30);
			this.dexEntryPlaceholder3.TabIndex = 19;
			this.dexEntryPlaceholder3.Click += new System.EventHandler(this.dexEntryPlaceholder3_Click);
			// 
			// namePlaceholder3
			// 
			this.namePlaceholder3.AutoSize = true;
			this.namePlaceholder3.Location = new System.Drawing.Point(47, 9);
			this.namePlaceholder3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.namePlaceholder3.Name = "namePlaceholder3";
			this.namePlaceholder3.Size = new System.Drawing.Size(65, 13);
			this.namePlaceholder3.TabIndex = 1;
			this.namePlaceholder3.Text = "pokeName1";
			// 
			// dexNoPlaceHolder3
			// 
			this.dexNoPlaceHolder3.AutoSize = true;
			this.dexNoPlaceHolder3.Location = new System.Drawing.Point(2, 9);
			this.dexNoPlaceHolder3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dexNoPlaceHolder3.Name = "dexNoPlaceHolder3";
			this.dexNoPlaceHolder3.Size = new System.Drawing.Size(44, 13);
			this.dexNoPlaceHolder3.TabIndex = 0;
			this.dexNoPlaceHolder3.Text = "dexNo1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.pokeAbility2);
			this.panel1.Controls.Add(this.pokeAbilityHidden);
			this.panel1.Controls.Add(this.pokeAbility1);
			this.panel1.Controls.Add(this.currentWeight);
			this.panel1.Controls.Add(this.currentHeight);
			this.panel1.Controls.Add(this.currentSpecies);
			this.panel1.Controls.Add(this.pokeType2);
			this.panel1.Controls.Add(this.pokeType1);
			this.panel1.Controls.Add(this.currentDexNo);
			this.panel1.Controls.Add(this.abilitiesLabel);
			this.panel1.Controls.Add(this.weightLabel);
			this.panel1.Controls.Add(this.heightLabel);
			this.panel1.Controls.Add(this.speciesLabel);
			this.panel1.Controls.Add(this.typeLabel);
			this.panel1.Controls.Add(this.nationalDexLabel);
			this.panel1.Controls.Add(this.pokePicture);
			this.panel1.Location = new System.Drawing.Point(222, 136);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(302, 180);
			this.panel1.TabIndex = 20;
			// 
			// pokeAbility2
			// 
			this.pokeAbility2.AutoSize = true;
			this.pokeAbility2.BackColor = System.Drawing.Color.White;
			this.pokeAbility2.Location = new System.Drawing.Point(124, 157);
			this.pokeAbility2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pokeAbility2.Name = "pokeAbility2";
			this.pokeAbility2.Size = new System.Drawing.Size(39, 13);
			this.pokeAbility2.TabIndex = 15;
			this.pokeAbility2.Text = "ability2";
			// 
			// pokeAbilityHidden
			// 
			this.pokeAbilityHidden.AutoSize = true;
			this.pokeAbilityHidden.BackColor = System.Drawing.Color.White;
			this.pokeAbilityHidden.Location = new System.Drawing.Point(180, 157);
			this.pokeAbilityHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pokeAbilityHidden.Name = "pokeAbilityHidden";
			this.pokeAbilityHidden.Size = new System.Drawing.Size(68, 13);
			this.pokeAbilityHidden.TabIndex = 14;
			this.pokeAbilityHidden.Text = "hidden ability";
			// 
			// pokeAbility1
			// 
			this.pokeAbility1.AutoSize = true;
			this.pokeAbility1.BackColor = System.Drawing.Color.White;
			this.pokeAbility1.Location = new System.Drawing.Point(72, 157);
			this.pokeAbility1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pokeAbility1.Name = "pokeAbility1";
			this.pokeAbility1.Size = new System.Drawing.Size(39, 13);
			this.pokeAbility1.TabIndex = 13;
			this.pokeAbility1.Text = "ability1";
			// 
			// currentWeight
			// 
			this.currentWeight.AutoSize = true;
			this.currentWeight.BackColor = System.Drawing.Color.White;
			this.currentWeight.Location = new System.Drawing.Point(71, 122);
			this.currentWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.currentWeight.Name = "currentWeight";
			this.currentWeight.Size = new System.Drawing.Size(66, 13);
			this.currentWeight.TabIndex = 12;
			this.currentWeight.Text = "PokeWeight";
			// 
			// currentHeight
			// 
			this.currentHeight.AutoSize = true;
			this.currentHeight.BackColor = System.Drawing.Color.White;
			this.currentHeight.Location = new System.Drawing.Point(71, 96);
			this.currentHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.currentHeight.Name = "currentHeight";
			this.currentHeight.Size = new System.Drawing.Size(63, 13);
			this.currentHeight.TabIndex = 11;
			this.currentHeight.Text = "PokeHeight";
			// 
			// currentSpecies
			// 
			this.currentSpecies.AutoSize = true;
			this.currentSpecies.BackColor = System.Drawing.Color.White;
			this.currentSpecies.Location = new System.Drawing.Point(72, 63);
			this.currentSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.currentSpecies.Name = "currentSpecies";
			this.currentSpecies.Size = new System.Drawing.Size(70, 13);
			this.currentSpecies.TabIndex = 10;
			this.currentSpecies.Text = "PokeSpecies";
			// 
			// pokeType2
			// 
			this.pokeType2.AutoSize = true;
			this.pokeType2.BackColor = System.Drawing.Color.White;
			this.pokeType2.Location = new System.Drawing.Point(142, 34);
			this.pokeType2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pokeType2.Name = "pokeType2";
			this.pokeType2.Size = new System.Drawing.Size(62, 13);
			this.pokeType2.TabIndex = 9;
			this.pokeType2.Text = "PokeType2";
			// 
			// pokeType1
			// 
			this.pokeType1.AutoSize = true;
			this.pokeType1.BackColor = System.Drawing.Color.White;
			this.pokeType1.Location = new System.Drawing.Point(72, 35);
			this.pokeType1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pokeType1.Name = "pokeType1";
			this.pokeType1.Size = new System.Drawing.Size(62, 13);
			this.pokeType1.TabIndex = 8;
			this.pokeType1.Text = "PokeType1";
			// 
			// currentDexNo
			// 
			this.currentDexNo.AutoSize = true;
			this.currentDexNo.BackColor = System.Drawing.Color.White;
			this.currentDexNo.Location = new System.Drawing.Point(72, 9);
			this.currentDexNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.currentDexNo.Name = "currentDexNo";
			this.currentDexNo.Size = new System.Drawing.Size(40, 13);
			this.currentDexNo.TabIndex = 7;
			this.currentDexNo.Text = "DexNo";
			// 
			// abilitiesLabel
			// 
			this.abilitiesLabel.AutoSize = true;
			this.abilitiesLabel.BackColor = System.Drawing.Color.White;
			this.abilitiesLabel.Location = new System.Drawing.Point(18, 157);
			this.abilitiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.abilitiesLabel.Name = "abilitiesLabel";
			this.abilitiesLabel.Size = new System.Drawing.Size(42, 13);
			this.abilitiesLabel.TabIndex = 6;
			this.abilitiesLabel.Text = "Abilities";
			// 
			// weightLabel
			// 
			this.weightLabel.AutoSize = true;
			this.weightLabel.BackColor = System.Drawing.Color.White;
			this.weightLabel.Location = new System.Drawing.Point(18, 122);
			this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.weightLabel.Name = "weightLabel";
			this.weightLabel.Size = new System.Drawing.Size(41, 13);
			this.weightLabel.TabIndex = 5;
			this.weightLabel.Text = "Weight";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.BackColor = System.Drawing.Color.White;
			this.heightLabel.Location = new System.Drawing.Point(18, 96);
			this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(38, 13);
			this.heightLabel.TabIndex = 4;
			this.heightLabel.Text = "Height";
			// 
			// speciesLabel
			// 
			this.speciesLabel.AutoSize = true;
			this.speciesLabel.BackColor = System.Drawing.Color.White;
			this.speciesLabel.Location = new System.Drawing.Point(18, 63);
			this.speciesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.speciesLabel.Name = "speciesLabel";
			this.speciesLabel.Size = new System.Drawing.Size(45, 13);
			this.speciesLabel.TabIndex = 3;
			this.speciesLabel.Text = "Species";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.BackColor = System.Drawing.Color.White;
			this.typeLabel.Location = new System.Drawing.Point(18, 35);
			this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(34, 13);
			this.typeLabel.TabIndex = 2;
			this.typeLabel.Text = "Type:";
			// 
			// nationalDexLabel
			// 
			this.nationalDexLabel.AutoSize = true;
			this.nationalDexLabel.BackColor = System.Drawing.Color.White;
			this.nationalDexLabel.Location = new System.Drawing.Point(2, 9);
			this.nationalDexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.nationalDexLabel.Name = "nationalDexLabel";
			this.nationalDexLabel.Size = new System.Drawing.Size(66, 13);
			this.nationalDexLabel.TabIndex = 1;
			this.nationalDexLabel.Text = "National No.";
			// 
			// pokePicture
			// 
			this.pokePicture.BackColor = System.Drawing.Color.White;
			this.pokePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pokePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pokePicture.InitialImage = null;
			this.pokePicture.Location = new System.Drawing.Point(146, 60);
			this.pokePicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pokePicture.Name = "pokePicture";
			this.pokePicture.Size = new System.Drawing.Size(76, 82);
			this.pokePicture.TabIndex = 0;
			this.pokePicture.TabStop = false;
			this.pokePicture.WaitOnLoad = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(587, 180);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(76, 79);
			this.richTextBox1.TabIndex = 21;
			this.richTextBox1.Text = "do we want dex descriptions?\n";
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(719, 369);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dexEntryPlaceholder3);
			this.Controls.Add(this.dexEntryPlaceholder4);
			this.Controls.Add(this.dexEntryPlaceholder5);
			this.Controls.Add(this.dexEntryPlaceholder2);
			this.Controls.Add(this.testUpButton);
			this.Controls.Add(this.testDownButton);
			this.Controls.Add(this.dexEntryPlaceholder1);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.SeenText);
			this.Controls.Add(this.CaughtText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WelcomeLabel);
			this.Controls.Add(this.DexLabel);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchBar);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainPage";
			this.Text = "DexDB";
			this.dexEntryPlaceholder1.ResumeLayout(false);
			this.dexEntryPlaceholder1.PerformLayout();
			this.dexEntryPlaceholder2.ResumeLayout(false);
			this.dexEntryPlaceholder2.PerformLayout();
			this.dexEntryPlaceholder5.ResumeLayout(false);
			this.dexEntryPlaceholder5.PerformLayout();
			this.dexEntryPlaceholder4.ResumeLayout(false);
			this.dexEntryPlaceholder4.PerformLayout();
			this.dexEntryPlaceholder3.ResumeLayout(false);
			this.dexEntryPlaceholder3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pokePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();


		}

		#endregion

		private System.Windows.Forms.TextBox SearchBar;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Label DexLabel;
		private System.Windows.Forms.Label WelcomeLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CaughtText;
		private System.Windows.Forms.TextBox SeenText;
		private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel dexEntryPlaceholder1;
        private System.Windows.Forms.Button testDownButton;
        private System.Windows.Forms.Button testUpButton;
        private System.Windows.Forms.Label dexNoPlaceHolder1;
        private System.Windows.Forms.Label namePlaceholder1;
        private System.Windows.Forms.Panel dexEntryPlaceholder2;
        private System.Windows.Forms.Label namePlaceholder2;
        private System.Windows.Forms.Label dexNoPlaceHolder2;
        private System.Windows.Forms.Panel dexEntryPlaceholder5;
        private System.Windows.Forms.Label namePlaceholder5;
        private System.Windows.Forms.Label dexNoPlaceHolder5;
        private System.Windows.Forms.Panel dexEntryPlaceholder4;
        private System.Windows.Forms.Label namePlaceholder4;
        private System.Windows.Forms.Label dexNoPlaceHolder4;
        private System.Windows.Forms.Panel dexEntryPlaceholder3;
        private System.Windows.Forms.Label namePlaceholder3;
        private System.Windows.Forms.Label dexNoPlaceHolder3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pokePicture;
        private Label abilitiesLabel;
        private Label weightLabel;
        private Label heightLabel;
        private Label speciesLabel;
        private Label typeLabel;
        private Label nationalDexLabel;
        private Label pokeAbility2;
        private Label pokeAbilityHidden;
        private Label pokeAbility1;
        private Label currentWeight;
        private Label currentHeight;
        private Label currentSpecies;
        private Label pokeType2;
        private Label pokeType1;
        private Label currentDexNo;
    }
}

