using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_hw3_FarmerGame
{
	public partial class Form1 : Form
	{
		string farmer = "Farmer";
		string vegetable = "Vegetable";
		string goat = "Goat";
		string wolf = "Wolf";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listBox1.Items.Add(farmer);
			listBox1.Items.Add(vegetable);
			listBox1.Items.Add(goat);
			listBox1.Items.Add(wolf);
			check_condition();
		}

		private void check_condition()
		{
			if(listBox2.Items.Contains(farmer))
			{
				left.Enabled = true;
				listBox2.Enabled = true;
				right.Enabled = false;
				listBox1.Enabled = false;
				if (listBox1.Items.Contains(vegetable) &&listBox1.Items.Contains(goat))
				{
					dead(goat, vegetable);
				}
				else if (listBox1.Items.Contains(goat)&&listBox1.Items.Contains(wolf))
				{
					dead(wolf, goat);
				}
			}
			else if (listBox1.Items.Contains(farmer))
			{
				right.Enabled = true;
				listBox1.Enabled = true;
				left.Enabled = false;
				listBox2.Enabled = false;
				if (listBox2.Items.Contains(vegetable) && listBox2.Items.Contains(goat))
				{
					dead(goat, vegetable);
				}
				else if (listBox2.Items.Contains(goat) && listBox2.Items.Contains(wolf))
				{
					dead(wolf, goat);
				}
			}

			if(listBox2.Items.Count==4)
			{
				endgame();
			}
		}

		private void Right_Click(object sender, EventArgs e)
		{
			try
			{
				if (!listBox1.SelectedItem.ToString().Equals(farmer))
				{
					listBox2.Items.Add(listBox1.SelectedItem);
					listBox1.Items.Remove(listBox1.SelectedItem);
					listBox2.Items.Add(farmer);
					listBox1.Items.Remove(farmer);
				}
				else if (listBox1.SelectedItem.ToString().Equals(farmer))
				{
					listBox2.Items.Add(farmer);
					listBox1.Items.Remove(farmer);
				}
				check_condition();
			}
			catch(System.NullReferenceException)
			{
				Err();
			}
		}

		private void Left_Click(object sender, EventArgs e)
		{
			try
			{
				if (!listBox2.SelectedItem.ToString().Equals(farmer))
				{
					listBox1.Items.Add(listBox2.SelectedItem);
					listBox2.Items.Remove(listBox2.SelectedItem);
					listBox1.Items.Add(farmer);
					listBox2.Items.Remove(farmer);
				}
				else if (listBox2.SelectedItem.ToString().Equals(farmer))
				{
					listBox1.Items.Add(farmer);
					listBox2.Items.Remove(farmer);
				}
				check_condition();
			}
			catch(System.NullReferenceException)
			{
				Err();
			}
		}

		private void dead(string one,string two)
		{
			MessageBox.Show("You failed!\nThe " + one + " eat the " + two + "!");
			Application.Restart();
		}
		private void endgame()
		{
			MessageBox.Show("You Succeed!");
			Application.Restart();
		}
		private void Err()
		{
			MessageBox.Show("Please choose a member!");
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1.Farmer can only bring one member with him.\n2.Goat will eat the vegetable, wolf will eat the goat.\n" +
				"3.All member need to cross the river to succeed the mission.","How to play",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
