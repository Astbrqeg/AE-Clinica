using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE_Clinica
{
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form F = new MainPage();
            F.Show();
            this.Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxWeight.Text = "";
            textBoxHeight.Text = "";
            textBoxResult.Text = "";
            radioButtonKilogram.Checked = false;
            radioButtonPound.Checked = false;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBoxWeight.Text);
            double height = Convert.ToDouble(textBoxHeight.Text);
            double result = 0.0;
            string result2 = "";
            if (radioButtonKilogram.Checked)
                result = weight / (height * height);
            else
            if (radioButtonPound.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);

            }

            if (result < 18.5)
                result2 = "You are underweight ";
            else
                if (result < 25)
                result2 = "You have normal weight";
            else
                if (result < 30)
                result2 = "You are overweight";
            else
                if (result >= 30)
                result2 = "You are obese";



            textBoxResult.Text = "Your BMI is: " + result.ToString("#.#") + "\r\n" + result2;



        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}