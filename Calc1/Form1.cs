using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //kkk

        private void button1_Click(object sender, EventArgs e)
        {
            
            double num1 = 0;
            double num2=0;
            if (textBox1.Text == "") {
                
                label1.Text = "error";
                return; }
            bool check1 = double.TryParse(textBox1.Text, out num1);
            if(!check1) {
               
                label1.Text = "error";
                return; }

            if (textBox2.Text == "") {
                label1.Text = "error";
                
                return; }
            bool check2 = double.TryParse(textBox2.Text, out num2);
            if (!check2) {
                label1.Text = "error";
             
                return; }

            double result=0;
            if (comboBox1.SelectedItem.ToString() == "+")
            {
                result = num1 + num2;
            }

           else if (comboBox1.SelectedItem.ToString() == "-")
            {
                result = num1 - num2;
            }

            else if (comboBox1.SelectedItem.ToString() == "*")
            {
                result = num1 * num2;
            }

            else if (comboBox1.SelectedItem.ToString() == "/")
            {
                if (num2 == 0) {
                    label1.Text = "error";
                  
                    return; }
                result = num1 / num2;
            }

            else
            {
                label1.Text = "error";
             
                return;
            }

     
         
                label1.Text= result.ToString();

            

        }
    }
}
