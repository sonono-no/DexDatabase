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
			this.SuspendLayout();
			// 
			// SearchBar
			// 
			this.SearchBar.AcceptsTab = true;
			this.SearchBar.Location = new System.Drawing.Point(240, 105);
			this.SearchBar.Margin = new System.Windows.Forms.Padding(2);
			this.SearchBar.Name = "SearchBar";
			this.SearchBar.Size = new System.Drawing.Size(185, 20);
			this.SearchBar.TabIndex = 0;
			this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(445, 105);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(57, 20);
			this.SearchButton.TabIndex = 1;
			this.SearchButton.Text = "Search";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// DexLabel
			// 
			this.DexLabel.AutoSize = true;
			this.DexLabel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DexLabel.ForeColor = System.Drawing.Color.Blue;
			this.DexLabel.Location = new System.Drawing.Point(330, 9);
			this.DexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DexLabel.Name = "DexLabel";
			this.DexLabel.Size = new System.Drawing.Size(105, 26);
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
			this.CaughtText.Size = new System.Drawing.Size(68, 20);
			this.CaughtText.TabIndex = 6;
			// 
			// SeenText
			// 
			this.SeenText.Location = new System.Drawing.Point(357, 68);
			this.SeenText.Margin = new System.Windows.Forms.Padding(2);
			this.SeenText.Name = "SeenText";
			this.SeenText.Size = new System.Drawing.Size(68, 20);
			this.SeenText.TabIndex = 7;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(587, 35);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(95, 23);
			this.AddButton.TabIndex = 8;
			this.AddButton.Text = "Add Pokemon";
			this.AddButton.UseVisualStyleBackColor = true;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(719, 369);
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
			this.Text = "Form1";
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
	}
}

