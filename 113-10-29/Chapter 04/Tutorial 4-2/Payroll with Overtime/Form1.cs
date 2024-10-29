﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal hourWorked, hourlyPayRate, grossPay;
            const decimal BASE_HOURS = 40m;
            const decimal OVERTIME_RATE = 1.5m;

            try
            {
                hourWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hourWorked > BASE_HOURS)
                {
                    grossPay = (BASE_HOURS * hourlyPayRate) + 
                               ((hourWorked - BASE_HOURS) * hourlyPayRate * OVERTIME_RATE);
                }
                else 
                {
                    grossPay = hourWorked * hourlyPayRate;
                }

                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
