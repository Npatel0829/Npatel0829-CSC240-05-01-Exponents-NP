﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Neel Patel 
 * Date: 07-22-2024
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class UxExponentsform : Form
    {
        public UxExponentsform()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num;

            // INPUT
            num = Convert.ToInt32(UxInputTextBox.Text);
            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            int squareAnswer = Square(num);
            UxOutputLabel.Text = "Square is " + squareAnswer.ToString();
            


            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            UxOutputLabel.Text += "\ncube is " + Cube(num).ToString();


            // OUTPUT
            UxOutputLabel.Visible = true;
            UxOutputLabel.ForeColor = Color.Green;

            // turn the Go button off
            UxGoButton.Enabled = false;
            
        }

        public int Square(int num)
        {
            return num * num;
            
            
        }

        public int Cube(int num)
        {
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied

            UxInputTextBox.Text = string.Empty;
            UxOutputLabel.Text = string.Empty;

            // turn the output to invisible

            UxOutputLabel.Visible = false;

            // turn the Go button back on

            UxGoButton.Enabled = true;
        }
    }
}
