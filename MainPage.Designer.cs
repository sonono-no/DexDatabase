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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SearchBar
			// 
			this.SearchBar.AcceptsTab = true;
			this.SearchBar.Location = new System.Drawing.Point(259, 92);
			this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
			this.SearchBar.Name = "SearchBar";
			this.SearchBar.Size = new System.Drawing.Size(185, 20);
			this.SearchBar.TabIndex = 0;
			this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.White;
			this.SearchButton.Location = new System.Drawing.Point(448, 91);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
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
			this.DexLabel.BackColor = System.Drawing.Color.Transparent;
			this.DexLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DexLabel.ForeColor = System.Drawing.Color.Ivory;
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
			this.CaughtText.Margin = new System.Windows.Forms.Padding(2);
			this.CaughtText.Name = "CaughtText";
			this.CaughtText.ReadOnly = true;
			this.CaughtText.Size = new System.Drawing.Size(68, 20);
			this.CaughtText.TabIndex = 6;
			// 
			// SeenText
			// 
			this.SeenText.Location = new System.Drawing.Point(357, 68);
			this.SeenText.Margin = new System.Windows.Forms.Padding(2);
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
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabControl1.ItemSize = new System.Drawing.Size(10, 100);
			this.tabControl1.Location = new System.Drawing.Point(0, 117);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(1, 3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(726, 252);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 9;
			this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPage1.Location = new System.Drawing.Point(104, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(618, 244);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Test page1";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(104, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(618, 244);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(104, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(618, 244);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(104, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(618, 244);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(719, 369);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.SeenText);
			this.Controls.Add(this.CaughtText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WelcomeLabel);
			this.Controls.Add(this.DexLabel);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchBar);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainPage";
			this.Text = "DexDB";
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label3;
	}
}

