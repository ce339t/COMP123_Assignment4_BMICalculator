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
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kgtextbbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.cmtextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 153);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 38);
            this.textBox1.TabIndex = 0;
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imperialRadioButton.Location = new System.Drawing.Point(67, 142);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(94, 28);
            this.imperialRadioButton.TabIndex = 2;
            this.imperialRadioButton.Text = "Imperial";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            this.imperialRadioButton.CheckedChanged += new System.EventHandler(this.imperialRadioButton_CheckedChanged);
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Checked = true;
            this.metricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricRadioButton.Location = new System.Drawing.Point(170, 142);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(79, 28);
            this.metricRadioButton.TabIndex = 3;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            this.metricRadioButton.CheckedChanged += new System.EventHandler(this.metricRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.11483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.88517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Controls.Add(this.kgtextbbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmtextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.heightTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 186);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 233);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // kgtextbbox
            // 
            this.kgtextbbox.BackColor = System.Drawing.Color.Black;
            this.kgtextbbox.ForeColor = System.Drawing.Color.White;
            this.kgtextbbox.Location = new System.Drawing.Point(193, 50);
            this.kgtextbbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.kgtextbbox.Name = "kgtextbbox";
            this.kgtextbbox.ReadOnly = true;
            this.kgtextbbox.Size = new System.Drawing.Size(34, 30);
            this.kgtextbbox.TabIndex = 7;
            this.kgtextbbox.Text = "kg";
            this.kgtextbbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "My Weight";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(127, 50);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.weightTextBox.Size = new System.Drawing.Size(66, 30);
            this.weightTextBox.TabIndex = 3;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // cmtextBox
            // 
            this.cmtextBox.BackColor = System.Drawing.Color.Black;
            this.cmtextBox.ForeColor = System.Drawing.Color.White;
            this.cmtextBox.Location = new System.Drawing.Point(193, 3);
            this.cmtextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cmtextBox.Name = "cmtextBox";
            this.cmtextBox.ReadOnly = true;
            this.cmtextBox.Size = new System.Drawing.Size(34, 30);
            this.cmtextBox.TabIndex = 6;
            this.cmtextBox.Text = "cm";
            this.cmtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Black;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 127);
            this.CalculateBMIButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(121, 32);
            this.CalculateBMIButton.TabIndex = 4;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(127, 127);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(108, 32);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // heightTextBox
            // 
            this.heightTextBox.AccessibleName = "heightTextBox";
            this.heightTextBox.Location = new System.Drawing.Point(127, 3);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(66, 30);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "My Height";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.Black;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resultTextBox.Location = new System.Drawing.Point(-3, 22);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(313, 76);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Black;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(-3, -1);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(313, 23);
            this.B.TabIndex = 7;
            this.B.Text = "BMI";
            this.B.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.Black;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(-3, 98);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(313, 23);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.B);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metricRadioButton);
            this.Controls.Add(this.imperialRadioButton);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private TextBox heightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private TextBox kgtextbbox;
        private TextBox cmtextBox;
        private TextBox resultTextBox;
        private Label B;
        private Label resultLabel;
    }
}

