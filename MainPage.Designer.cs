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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
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
            this.namePlaceholder1 = new System.Windows.Forms.Label();
            this.dexNoPlaceHolder1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.SearchBar.Location = new System.Drawing.Point(345, 113);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(245, 22);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(597, 112);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(76, 25);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DexLabel
            // 
            this.DexLabel.AutoSize = true;
            this.DexLabel.BackColor = System.Drawing.Color.Transparent;
            this.DexLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexLabel.ForeColor = System.Drawing.Color.Ivory;
            this.DexLabel.Location = new System.Drawing.Point(440, 11);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(126, 32);
            this.DexLabel.TabIndex = 2;
            this.DexLabel.Text = "DEX DB";
            this.DexLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.WelcomeLabel.Location = new System.Drawing.Point(20, 18);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(0, 24);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(341, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pokemon Caught:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(353, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pokemon Seen:";
            // 
            // CaughtText
            // 
            this.CaughtText.Location = new System.Drawing.Point(476, 57);
            this.CaughtText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaughtText.Name = "CaughtText";
            this.CaughtText.ReadOnly = true;
            this.CaughtText.Size = new System.Drawing.Size(89, 22);
            this.CaughtText.TabIndex = 6;
            // 
            // SeenText
            // 
            this.SeenText.Location = new System.Drawing.Point(476, 84);
            this.SeenText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeenText.Name = "SeenText";
            this.SeenText.ReadOnly = true;
            this.SeenText.Size = new System.Drawing.Size(89, 22);
            this.SeenText.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(783, 43);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 28);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Pokemon";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // dexEntryPlaceholder1
            // 
            this.dexEntryPlaceholder1.BackColor = System.Drawing.SystemColors.Info;
            this.dexEntryPlaceholder1.Controls.Add(this.namePlaceholder1);
            this.dexEntryPlaceholder1.Controls.Add(this.dexNoPlaceHolder1);
            this.dexEntryPlaceholder1.Location = new System.Drawing.Point(24, 168);
            this.dexEntryPlaceholder1.Name = "dexEntryPlaceholder1";
            this.dexEntryPlaceholder1.Size = new System.Drawing.Size(200, 37);
            this.dexEntryPlaceholder1.TabIndex = 9;
            this.dexEntryPlaceholder1.Click += new System.EventHandler(this.dexEntryPlaceholder1_Click);
            // 
            // namePlaceholder1
            // 
            this.namePlaceholder1.AutoSize = true;
            this.namePlaceholder1.Location = new System.Drawing.Point(63, 11);
            this.namePlaceholder1.Name = "namePlaceholder1";
            this.namePlaceholder1.Size = new System.Drawing.Size(82, 16);
            this.namePlaceholder1.TabIndex = 1;
            this.namePlaceholder1.Text = "pokeName1";
            // 
            // dexNoPlaceHolder1
            // 
            this.dexNoPlaceHolder1.AutoSize = true;
            this.dexNoPlaceHolder1.Location = new System.Drawing.Point(3, 11);
            this.dexNoPlaceHolder1.Name = "dexNoPlaceHolder1";
            this.dexNoPlaceHolder1.Size = new System.Drawing.Size(54, 16);
            this.dexNoPlaceHolder1.TabIndex = 0;
            this.dexNoPlaceHolder1.Text = "dexNo1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Down";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(863, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "UP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dexEntryPlaceholder2
            // 
            this.dexEntryPlaceholder2.Controls.Add(this.namePlaceholder2);
            this.dexEntryPlaceholder2.Controls.Add(this.dexNoPlaceHolder2);
            this.dexEntryPlaceholder2.Location = new System.Drawing.Point(24, 211);
            this.dexEntryPlaceholder2.Name = "dexEntryPlaceholder2";
            this.dexEntryPlaceholder2.Size = new System.Drawing.Size(200, 37);
            this.dexEntryPlaceholder2.TabIndex = 16;
            this.dexEntryPlaceholder2.Click += new System.EventHandler(this.dexEntryPlaceholder2_Click);
            // 
            // namePlaceholder2
            // 
            this.namePlaceholder2.AutoSize = true;
            this.namePlaceholder2.Location = new System.Drawing.Point(63, 11);
            this.namePlaceholder2.Name = "namePlaceholder2";
            this.namePlaceholder2.Size = new System.Drawing.Size(82, 16);
            this.namePlaceholder2.TabIndex = 1;
            this.namePlaceholder2.Text = "pokeName1";
            // 
            // dexNoPlaceHolder2
            // 
            this.dexNoPlaceHolder2.AutoSize = true;
            this.dexNoPlaceHolder2.Location = new System.Drawing.Point(3, 11);
            this.dexNoPlaceHolder2.Name = "dexNoPlaceHolder2";
            this.dexNoPlaceHolder2.Size = new System.Drawing.Size(54, 16);
            this.dexNoPlaceHolder2.TabIndex = 0;
            this.dexNoPlaceHolder2.Text = "dexNo1";
            // 
            // dexEntryPlaceholder5
            // 
            this.dexEntryPlaceholder5.Controls.Add(this.namePlaceholder5);
            this.dexEntryPlaceholder5.Controls.Add(this.dexNoPlaceHolder5);
            this.dexEntryPlaceholder5.Location = new System.Drawing.Point(24, 340);
            this.dexEntryPlaceholder5.Name = "dexEntryPlaceholder5";
            this.dexEntryPlaceholder5.Size = new System.Drawing.Size(200, 37);
            this.dexEntryPlaceholder5.TabIndex = 17;
            this.dexEntryPlaceholder5.Click += new System.EventHandler(this.dexEntryPlaceholder5_Click);
            // 
            // namePlaceholder5
            // 
            this.namePlaceholder5.AutoSize = true;
            this.namePlaceholder5.Location = new System.Drawing.Point(63, 11);
            this.namePlaceholder5.Name = "namePlaceholder5";
            this.namePlaceholder5.Size = new System.Drawing.Size(82, 16);
            this.namePlaceholder5.TabIndex = 1;
            this.namePlaceholder5.Text = "pokeName1";
            // 
            // dexNoPlaceHolder5
            // 
            this.dexNoPlaceHolder5.AutoSize = true;
            this.dexNoPlaceHolder5.Location = new System.Drawing.Point(3, 11);
            this.dexNoPlaceHolder5.Name = "dexNoPlaceHolder5";
            this.dexNoPlaceHolder5.Size = new System.Drawing.Size(54, 16);
            this.dexNoPlaceHolder5.TabIndex = 0;
            this.dexNoPlaceHolder5.Text = "dexNo1";
            // 
            // dexEntryPlaceholder4
            // 
            this.dexEntryPlaceholder4.Controls.Add(this.namePlaceholder4);
            this.dexEntryPlaceholder4.Controls.Add(this.dexNoPlaceHolder4);
            this.dexEntryPlaceholder4.Location = new System.Drawing.Point(24, 297);
            this.dexEntryPlaceholder4.Name = "dexEntryPlaceholder4";
            this.dexEntryPlaceholder4.Size = new System.Drawing.Size(200, 37);
            this.dexEntryPlaceholder4.TabIndex = 18;
            this.dexEntryPlaceholder4.Click += new System.EventHandler(this.dexEntryPlaceholder4_Click);
            // 
            // namePlaceholder4
            // 
            this.namePlaceholder4.AutoSize = true;
            this.namePlaceholder4.Location = new System.Drawing.Point(63, 11);
            this.namePlaceholder4.Name = "namePlaceholder4";
            this.namePlaceholder4.Size = new System.Drawing.Size(82, 16);
            this.namePlaceholder4.TabIndex = 1;
            this.namePlaceholder4.Text = "pokeName1";
            // 
            // dexNoPlaceHolder4
            // 
            this.dexNoPlaceHolder4.AutoSize = true;
            this.dexNoPlaceHolder4.Location = new System.Drawing.Point(3, 11);
            this.dexNoPlaceHolder4.Name = "dexNoPlaceHolder4";
            this.dexNoPlaceHolder4.Size = new System.Drawing.Size(54, 16);
            this.dexNoPlaceHolder4.TabIndex = 0;
            this.dexNoPlaceHolder4.Text = "dexNo1";
            // 
            // dexEntryPlaceholder3
            // 
            this.dexEntryPlaceholder3.Controls.Add(this.namePlaceholder3);
            this.dexEntryPlaceholder3.Controls.Add(this.dexNoPlaceHolder3);
            this.dexEntryPlaceholder3.Location = new System.Drawing.Point(24, 254);
            this.dexEntryPlaceholder3.Name = "dexEntryPlaceholder3";
            this.dexEntryPlaceholder3.Size = new System.Drawing.Size(200, 37);
            this.dexEntryPlaceholder3.TabIndex = 19;
            this.dexEntryPlaceholder3.Click += new System.EventHandler(this.dexEntryPlaceholder3_Click);
            // 
            // namePlaceholder3
            // 
            this.namePlaceholder3.AutoSize = true;
            this.namePlaceholder3.Location = new System.Drawing.Point(63, 11);
            this.namePlaceholder3.Name = "namePlaceholder3";
            this.namePlaceholder3.Size = new System.Drawing.Size(82, 16);
            this.namePlaceholder3.TabIndex = 1;
            this.namePlaceholder3.Text = "pokeName1";
            // 
            // dexNoPlaceHolder3
            // 
            this.dexNoPlaceHolder3.AutoSize = true;
            this.dexNoPlaceHolder3.Location = new System.Drawing.Point(3, 11);
            this.dexNoPlaceHolder3.Name = "dexNoPlaceHolder3";
            this.dexNoPlaceHolder3.Size = new System.Drawing.Size(54, 16);
            this.dexNoPlaceHolder3.TabIndex = 0;
            this.dexNoPlaceHolder3.Text = "dexNo1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pokePicture);
            this.panel1.Location = new System.Drawing.Point(325, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 222);
            this.panel1.TabIndex = 20;
            // 
            // pokePicture
            // 
            this.pokePicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pokePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pokePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pokePicture.InitialImage = null;
            this.pokePicture.Location = new System.Drawing.Point(151, 23);
            this.pokePicture.Name = "pokePicture";
            this.pokePicture.Size = new System.Drawing.Size(100, 100);
            this.pokePicture.TabIndex = 0;
            this.pokePicture.TabStop = false;
            this.pokePicture.WaitOnLoad = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(834, 241);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "do we want dex descriptions?\n";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 454);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dexEntryPlaceholder3);
            this.Controls.Add(this.dexEntryPlaceholder4);
            this.Controls.Add(this.dexEntryPlaceholder5);
            this.Controls.Add(this.dexEntryPlaceholder2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}

