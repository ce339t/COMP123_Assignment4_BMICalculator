using System;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
