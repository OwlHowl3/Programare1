using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            double principal = double.Parse(Interaction.InputBox("Enter initial principal amount:"));
            double annualInterestRate = double.Parse(Interaction.InputBox("Enter annual interest rate:"));
            int years = int.Parse(Interaction.InputBox("Enter the number of years:"));
            int compoundingFrequency = int.Parse(Interaction.InputBox("Enter the number of times the interest is compounded per year: "));
            double compoundInterest = CalculateCompoundInterest(
                principal, annualInterestRate, years, compoundingFrequency
            );
            MessageBox.Show($"The future value of your investment is: {compoundInterest:C}");
        }

        static double CalculateCompoundInterest(
            double principal, double annualInterestRate, int years, int compoundingFrequency
        )
        {

            double compoundInterest;
            double init = Math.Pow(
                (1 + (annualInterestRate / 100) / compoundingFrequency),
                compoundingFrequency * years
            );
            compoundInterest = principal * init;

            return compoundInterest;
        }
    }
}
