using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private CalculatorClass calculate;
        private double Num1, Num2;

        public FrmCalculator()
        {
            InitializeComponent();
            calculate = new CalculatorClass();

            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                Num1 = Convert.ToDouble(txtInboxInput1.Text);
                Num2 = Convert.ToDouble(txtInboxInput2.Text);

                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        calculate.CalculateEvent += calculate.GetSum;
                        lblDisplayTotal.Text = calculate.GetSum(Num1, Num2).ToString();
                        break;
                    case "-":
                        calculate.CalculateEvent -= calculate.GetDifference;
                        lblDisplayTotal.Text = calculate.GetDifference(Num1, Num2).ToString();
                        break;
                    case "*":
                        calculate.CalculateEvent += calculate.GetProduct;
                        lblDisplayTotal.Text = calculate.GetProduct(Num1, Num2).ToString();
                        calculate.CalculateEvent -= calculate.GetProduct;
                        break;
                    case "/":
                        if (Num2 != 0)
                        {
                            calculate.CalculateEvent += calculate.GetQuotient;
                            lblDisplayTotal.Text = calculate.GetQuotient(Num1, Num2).ToString();
                            calculate.CalculateEvent -= calculate.GetQuotient;
                        }
                        else
                        {
                            lblDisplayTotal.Text = "Error : The selected digits is dividable by 0. please try again.";
                        }
                        break;

                    default:
                        lblDisplayTotal.Text = "Please select an Operator to be used.";
                        break;

                }
            }
            catch (FormatException)
            {
                lblDisplayTotal.Text = "Invalid Input";
            }
        }
    }
}
