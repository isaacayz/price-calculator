using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
	public partial class Form1 : Form
	{
		//This program uses Microsof form to print receipt and calculate the price of blender purchase
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			const double SALES_TAX = .07;
			const double price = 39.95;
			double subTotal, total, taxTotal;
			int blenderQty;
			string name, address, city, state, zipCode;

			//Assignment
			name = textBox1.Text;
			address = textBox2.Text;
			city = textBox3.Text;
			state = textBox4.Text;
			zipCode = textBox5.Text;
			blenderQty = Convert.ToInt32(textBox6.Text);

			//Calculation 
			subTotal = blenderQty * price;
			taxTotal = subTotal * SALES_TAX;
			total = subTotal + taxTotal;

			//Output
			label3.Text = "\nReceipt for: \n" + name + "\n" + address + "\n" + city +
			", " + state + " " + zipCode + "\n\n" + blenderQty + " blenders ordered @" + 
			price.ToString("c") + " each" + "\n\nTotal: \t" + subTotal.ToString("c") + "\nTax: \t" +
			taxTotal.ToString("c") + "\n------------------------------------------" + "\nDue: \t" + total.ToString("c") + "\n------------------------------------------";

		}
	}
}
