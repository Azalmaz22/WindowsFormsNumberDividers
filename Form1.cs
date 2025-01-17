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
            var naturalNamber2 = 0;

            if (!string.IsNullOrWhiteSpace(inputStr2))
            {
                naturalNamber2 = int.Parse(inputStr2);
            }

            var sumDividers = 0;
            var sumEvenNumbers = 0;
            var sumOddNumbers = 0;               
            var sumLargeDividers = 0;


            var dividers = "";
            var evenNumbers = "";
            var oddNumbers = "";
            var largeDividers = "";

            for (int i = 1; i <= naturalNamber; i++)
            {
                if (naturalNamber % i == 0)
                {
                    dividers = dividers + " " + i;
                    sumDividers = sumDividers + i;

                    if (i % 2 == 0)
                    {
                        evenNumbers = evenNumbers + " " + i;
                        sumEvenNumbers = sumEvenNumbers + i;
                    }
                    else
                    {
                        oddNumbers = oddNumbers + " " + i;
                        sumOddNumbers = sumOddNumbers + i;
                    }

                    if (i > naturalNamber2 && !string.IsNullOrWhiteSpace(inputStr2))
                    {
                        largeDividers = largeDividers + " " + i;
                        sumLargeDividers = sumLargeDividers + i;
                    }

                }

            }

            txtBxDividers.Text = dividers;
            txtBxSumDividers.Text = sumDividers.ToString();
            txtBxEvenNumbers.Text = evenNumbers;
            txtBxSumEvenNumbers.Text = sumEvenNumbers.ToString();
            txtBxOddNumbers.Text = oddNumbers;
            txtBxSumOddNumders.Text = sumOddNumbers.ToString();
            txtBxLargeDividers.Text = largeDividers;  
            
            if (!string.IsNullOrWhiteSpace(inputStr2))
            txtBxSumLargeDividers.Text = sumLargeDividers.ToString();
            
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
    
