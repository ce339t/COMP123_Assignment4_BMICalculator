using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /* Created By: Christina May Pakingan
   Student #: 301121940
   COMP 123 - Assignment 4 - BMI Calculator
   Created on: July 29, 2020
   Modified: August 4,2020
    Last Modification: August 5, 2020
*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make only one decimal is allowed
            if (e.KeyChar == 46)
            {
                if (((TextBox) sender).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make only one decimal is allowed
            if (e.KeyChar == 46)
            {
                if (((TextBox)sender).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            // clear out all text boxes 
            heightTextBox.Clear();
            weightTextBox.Clear();
            resultTextBox.Clear();
            resultLabel.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            //check if text boxes are empty and display error message
            if (string.IsNullOrEmpty(weightTextBox.Text) || (string.IsNullOrEmpty(heightTextBox.Text)))
            {
                MessageBox.Show("Please Enter your Weight and Height!", "Error Message");
            }
            else
            {
                // if textbox are not empty -  proceed will calculation
                double bmi = 0;
                var result = "";
                double weight = Convert.ToDouble(weightTextBox.Text);
                double height = Convert.ToDouble(heightTextBox.Text);


                if (metricRadioButton.Checked)
                {
                    double heightInMeter = height/100;
                    bmi = weight / (heightInMeter * heightInMeter);
                }
                else
                {
                    bmi = (weight * 703) / (height * height);
                }

                if (bmi < 18.50)
                {
                    result = "Underweight";
                }
                else if (bmi <= 24.9)
                {
                    result = "Normal";
                }
                else if (bmi <= 29.9)
                {
                    result = "Overweight";
                }
                else if (bmi >= 30)
                {
                    result = "Obese";
                }

                // display the result in 2 decimal places
                resultTextBox.Text = $"{Math.Round(bmi, 2)}";
                resultLabel.Text = result;
            }
        }


        private void imperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // changes in textbox default text when user chooses imperial button
            if (imperialRadioButton.Checked)
            {
                kgtextbbox.Text = "lbs";
                cmtextBox.Text = "in";

                //clear textboxes to accept new input
                heightTextBox.Clear();
                weightTextBox.Clear();
                resultTextBox.Clear();
                resultLabel.Text = "";

            }
        }

        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // changes in textbox default text when user chooses imperial button
            if (metricRadioButton.Checked)
            {
                kgtextbbox.Text = "kg";
                cmtextBox.Text = "cm";
                //clear textboxes to accept new input
                heightTextBox.Clear();
                weightTextBox.Clear();
                resultTextBox.Clear();
                resultLabel.Text = "";
            }
        }

       
    }
}
