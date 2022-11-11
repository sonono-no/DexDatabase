﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexDatabase
{
	public partial class MainPage : Form
	{
		public MainPage()
		{
			InitializeComponent();

			tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
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

		private void MainPage_Load(object sender, EventArgs e)
		{

		}

		private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics g = e.Graphics;
			Brush _textBrush;

			// Get the item from the collection.
			TabPage _tabPage = tabControl1.TabPages[e.Index];

			// Get the real bounds for the tab rectangle.
			Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

			if (e.State == DrawItemState.Selected)
			{

				// Draw a different background color, and don't paint a focus rectangle.
				_textBrush = new SolidBrush(Color.Red);
				g.FillRectangle(Brushes.Gray, e.Bounds);
			}
			else
			{
				_textBrush = new System.Drawing.SolidBrush(e.ForeColor);
				e.DrawBackground();
			}

			// Use our own font.
			Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

			// Draw string. Center the text.
			StringFormat _stringFlags = new StringFormat();
			_stringFlags.Alignment = StringAlignment.Center;
			_stringFlags.LineAlignment = StringAlignment.Center;
			g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
