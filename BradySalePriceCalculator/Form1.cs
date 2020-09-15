using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Sale Price Calculator
* Author      : Kabrina Brady
* Created     : 9/7/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work, based on Tutorial 3-3
* Description : User enters original price and discount percentage, then program calculates sale price
*               Input:  Original price, discount percentage
*               Output: Sale price, and in some circumstances the Exception message
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace BradySalePriceCalculator
{
    public partial class salePriceCalculator : Form
    {
        public salePriceCalculator()
        {
            InitializeComponent();
        }

        private void SalePriceCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal originalPrice; //item's original price
                decimal discountPercentage; //discount percentage
                decimal discountAmount; //amount of discount
                decimal salePrice; //item's sale price

                //get item's original price
                originalPrice = decimal.Parse(txtOriginalPrice.Text);

                //get discount percentage
                discountPercentage = decimal.Parse(txtDiscountPercentage.Text);

                //move percentage's decimal point left two spaces
                discountPercentage = discountPercentage / 100;

                //calculate amount of discount
                discountAmount = originalPrice * discountPercentage;

                //calculate sale price
                salePrice = originalPrice - discountAmount;

                //display sale price
                txtSalePrice.Text = salePrice.ToString("c");
            }
            //if user enters a non-number, this error message is displayed
            catch (Exception nonNumber)
            {
                MessageBox.Show("Error: Please enter a number.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
