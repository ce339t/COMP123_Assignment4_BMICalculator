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
            heightTextBox.Clear();
            weightTextBox.Clear();
            resultTextBox.Clear();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double bmi;
            string result="";
            double weight = Convert.ToDouble(weightTextBox.Text);
            double height = Convert.ToDouble(heightTextBox.Text);
            if (metricRadioButton.Checked)
            {
                double heightInMeter = height / 100;
                bmi = weight / (heightInMeter * heightInMeter);
            }
            else
            {
                bmi = (weight * 703) / (height*height);
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

            Debug.WriteLine(bmi);
            resultTextBox.Text = $"Your BMI is {Math.Round(bmi,2)}/ {result}";

        }

        private void imperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imperialRadioButton.Checked)
            {
                kgtextbbox.Text = "lbs";
                cmtextBox.Text = "in";
                heightTextBox.Clear();
                weightTextBox.Clear();
                resultTextBox.Clear();

            }
        }

        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (metricRadioButton.Checked)
            {
                kgtextbbox.Text = "kg";
                cmtextBox.Text = "cm";
                heightTextBox.Clear();
                weightTextBox.Clear();
                resultTextBox.Clear();
            }
        }
    }
}
