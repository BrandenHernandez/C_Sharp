/*Create a GUI working calculator as discussed and demonstrated in class. 
 * Be sure to include a read only textbox, buttons 0-9, +, -, /, *, =, and a . for decimals. 
 * There should also be a way to clear the display, a clear button that will allow you to start over. 
 * You will need to use at least one private member called temp, 
 * and either Convert.ToDouble or Convert.ToDecimal depending upon which type you decide to use.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
	public partial class Form1 : Form
	{

		// Variables
		private int total;
		private int first;
		private int second;
		private string arithmetic;



		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) // Display Screen
		{

		}

		private void button1_Click(object sender, EventArgs e) // 1
		{
			screen.Text += "1";
		}

		private void button2_Click(object sender, EventArgs e) // 2
		{
			screen.Text += "2";
		}

		private void button3_Click(object sender, EventArgs e) // 3
		{
			screen.Text += "3";
		}

		private void button4_Click(object sender, EventArgs e) // 4
		{
			screen.Text += "4";
		}

		private void button5_Click(object sender, EventArgs e) // 5
		{
			screen.Text += "5";
		}

		private void button6_Click(object sender, EventArgs e) // 6
		{
			screen.Text += "6";
		}

		private void button7_Click(object sender, EventArgs e) // 7
		{
			screen.Text += "7";
		}

		private void button8_Click(object sender, EventArgs e) // 8
		{
			screen.Text += "8";
		}

		private void button9_Click(object sender, EventArgs e) // 9
		{
			screen.Text += "9";
		}

		private void button10_Click(object sender, EventArgs e) // 0
		{
			screen.Text += "0";
		}

		private void button11_Click(object sender, EventArgs e) // C (clear)
		{
			screen.Clear(); // Clear the screen
		}

		private void button12_Click(object sender, EventArgs e) // + (Addition)
		{
			arithmetic = "+";
			first = int.Parse(screen.Text); // Place current number into first variable
			screen.Clear(); // Clear the screen
		}

		private void button13_Click(object sender, EventArgs e) // - (Subtraction)
		{
			arithmetic = "-";
			first = int.Parse(screen.Text); // Place current number into first variable
			screen.Clear(); // Clear the screen
		}

		private void button14_Click(object sender, EventArgs e) // * (multiplication)
		{
			arithmetic = "*";
			first = int.Parse(screen.Text); // Place current number into first variable
			screen.Clear(); // Clear the screen
		}

		private void button15_Click(object sender, EventArgs e) // / (Division)
		{
			arithmetic = "/";
			first = int.Parse(screen.Text); // Place current number into first variable
			screen.Clear(); // Clear the screen
		}

		private void button16_Click(object sender, EventArgs e) // . (Decimal)
		{
			screen.Text = ".";
		}

		private void button17_Click(object sender, EventArgs e) // = (Equals)
		{
			second = int.Parse(screen.Text); // place current number into second variable

			switch (arithmetic)
			{
				case "+":
					total = first + second; // Addition
					break;
				case "-":
					total = first - second; // Subtraction
					break;
				case "*":
					total = first * second; // Mulitplication
					break;
				case "/":
					total = first / second;
					break;

			}

			screen.Text = total.ToString(); // Display total
		}
	}
// Thanks for looking
}
