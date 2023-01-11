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
    public partial class FormDoctorUpdate : Form
    {
        private Doctors currentDoctors;
        private int currentIndex;
        public FormDoctorUpdate()
        {
            InitializeComponent();
            currentDoctors = null;
        }



        private void FormDoctorUpdate_Load(object sender, EventArgs e)
        {
            if (Program.currentDoctor != null)
            {
                textBoxName.Text = Program.currentDoctor.Name;
                textBoxAddress.Text = Program.currentDoctor.Address;
                textBoxSpecialty.Text = Program.currentDoctor.Specialty;
                textBoxID.Text = Program.currentDoctor.Id;
                textBoxPhoneNumber.Text = Program.currentDoctor.Phonenumber;
                dateTimePickerBirthdate.Value = Program.currentDoctor.Birthdate;
                textBoxPassword.Text = Program.currentDoctor.Password;
            }
            if (currentDoctors != null)
            {
                textBoxName.Text = currentDoctors.Name;
                textBoxAddress.Text = currentDoctors.Address;
                textBoxSpecialty.Text = currentDoctors.Specialty;
                textBoxID.Text = currentDoctors.Id;
                textBoxPhoneNumber.Text = currentDoctors.Phonenumber;
                dateTimePickerBirthdate.Value = currentDoctors.Birthdate;
                textBoxPassword.Text = currentDoctors.Password;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            if (Program.currentDoctor != null)
            {
                Form f = new FormDoctorDetails();
                f.Show();
                this.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int number;
            bool success = int.TryParse(textBoxPhoneNumber.Text, out number);
            if (success)
            {
                Doctors newDoctors = new Doctors(textBoxName.Text,
                                                 textBoxAddress.Text,
                                                 textBoxSpecialty.Text,
                                                 textBoxID.Text,
                                                 textBoxPhoneNumber.Text,
                                                 dateTimePickerBirthdate.Value,
                                                 textBoxPassword.Text);
                if (Program.currentDoctor != null)
                    if (DoctorsDB.Update(Program.currentDoctor, newDoctors))

                    {
                    Program.currentDoctor = newDoctors;
                    MessageBox.Show("Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else
                labelError.Text = "The phone number must be a valid number";
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }
    }
}
