using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatordevice
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        // Hello
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This adds the number or operator to the string calculation
            currentCalculation += (sender as Button).Text;

            // Display the current calculation back to the user
            textBox1.Text = currentCalculation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
     
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button12_Click(object sender, EventArgs e)
        {
       
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
         
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button15_Click(object sender, EventArgs e)
        {
      
            currentCalculation += (sender as Button).Text;
            textBox1.Text = currentCalculation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString().Replace("X", "*").ToString().Replace("/;", "/");

            try
            {
                textBox1.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = textBox1.Text;
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
                currentCalculation = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            currentCalculation = "";
        }
    }
}
