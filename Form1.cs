using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
     
        {
                
                var inputStr = txtBxEnter.Text;
                var naturalNamber = int.Parse(inputStr);
                var inputStr2 = txtBxEnterLargeDividers.Text;
                var naturalNamber2 = int.Parse(inputStr2);

                var result = 0;
                var result_1 = 0;
                var result_2 = 0;
                var result_3 = 0;               
                
                var dividers = "";
                var evenNumbers = "";
                var oddNumbers = "";
                var largeDividers = "";

                for (int i = 1; i <= naturalNamber; i++)
                {
                    if (naturalNamber % i == 0)
                    {   
                        dividers = dividers + " " + i;
                        result = result + i;
                    }
                    if (naturalNamber % i == 0 && i % 2 == 0)
                    {    
                        evenNumbers = evenNumbers + " " + i;
                        result_1 = result_1 + i;
                    }
                    if (naturalNamber % i == 0 && i % 2 != 0)
                    {    
                        oddNumbers = oddNumbers + " " + i;
                        result_2 = result_2 + i;
                    }
                    if (naturalNamber % i == 0 && i > naturalNamber2)
                    {                   
                     largeDividers = largeDividers + " " + i;
                    result_3 = result_3 + i;
                    }

                }
            txtBxDividers.Text = dividers;
            txtBxSumDividers.Text = result.ToString();
            txtBxEvenNumbers.Text = evenNumbers;           
            txtBxSumEvenNumbers.Text = result_1.ToString();
            txtBxOddNumbers.Text = oddNumbers;
            txtBxSumOddNumders.Text = result_2.ToString();
            txtBxLargeDividers.Text = largeDividers;
            txtBxSumLargeDividers.Text = result_3.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxSumLargeDividers_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
    
