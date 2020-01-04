//Sabrina Turney
//C# I
//Program 6-7: Present Value
//Last Edited 9/14/2019

/*
Program Requirements and Notes:
Suppose you want to deposit a certain amount of money into a savings account and then leave it alone to draw interest for the next 10 years. 
At the end of 10 years you would like to have $10,000 in the account. How much do you need to deposit today to make that happen? 
You can use the following formula, which is known as the present-value formula, to find out:

       F
P =  -------
    (1+r)^n

The terms in the formula are as follows:
P is the present value, or the amount that you need to deposit today.
F is the future value that you want in the account. (In this case, F is $10,000.)
r is the annual interest rate.
n is the number of years that you plan to let the money sit in the account.

Write a method named PresentValue that performs this calculation. The method should accept the future value, annual interest rate, 
and number of years as arguments. It should return the present value, which is the amount that you need to deposit today. 
Demonstrate the method in an application that lets the user experiment with different values for the formula’s terms. 

 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class presentValue : Form
    {

        public presentValue()
        {
            InitializeComponent();
        }


        private void PresentValue_Load(object sender, EventArgs e)
        {

        }

        // The InputIsValid method converts the user input and stores 
        // it in the arguments (passed by reference). If the conversion 
        // is successful, the method returns true. Otherwise it returns 
        // false. 

        
          //This section of code is taken from the tutorial and tweaked so it can validate all three entered values by the user.

        private bool InputIsValid(ref decimal userFutureValue, ref decimal userAnnualInterest, ref decimal userYears)
        {
            // Flag variable to indicate whether the input is good 
            bool inputGood = false;

            // Try to convert all inputs to decimals. 

            if (decimal.TryParse(futureValue.Text, out userFutureValue))
            {
                if (decimal.TryParse(annualInterestRate.Text, out userAnnualInterest))
                {
                    if (decimal.TryParse(yearsFermenting.Text, out userYears))
                    {
                        // ALL inputs are good. 
                        inputGood = true;
                    }
                }

            }

            else
            { // Display an error message for the input. I refactored the tutorial code here- The user will understand what the input needs to be, instead of just receiving an error. 
                MessageBox.Show("One of your inputs is invalid. Please enter decimals or whole numbers only.");
            }
            // Return the result. 
            return inputGood;
        }
        private void CalcPresentValue_Click(object sender, EventArgs e)
        {
            //First I start off by declaring all the variables I'll use to calculate.
            decimal presentValue = 0m;
            decimal userFutureValue = 0m;
            decimal userAnnualInterest = 0m;
            decimal userYears = 0m;


            //only complete the calculations if the user inputs the correct values.
            if (InputIsValid(ref  userFutureValue, ref  userAnnualInterest, ref userYears))
            {
                //retrieve the values from user-entered information.
                userFutureValue = decimal.Parse(futureValue.Text);
                userAnnualInterest = decimal.Parse(annualInterestRate.Text);
                userYears = decimal.Parse(yearsFermenting.Text);

                //complete calculations, display result in text box for user.
                presentValue = userFutureValue / (decimal)Math.Pow((double)(1 + userAnnualInterest), (double)userYears);
                calculatedPresentValue.Text = presentValue.ToString("c");
            }


        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
