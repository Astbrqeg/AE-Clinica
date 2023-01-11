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
    public partial class FormPatientAdd : Form
    {
        public FormPatientAdd()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form f = new FormDoctorDetails();
            f.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            Patient newPatient = new Patient(textBoxName.Text,
                                               textBoxAddress.Text,
                                               textBoxID.Text,
                                               textBoxLength.Text,
                                               textBoxWeight.Text,
                                               textBoxPhoneNumber.Text,
                                               dateTimePickerBirthday.Value);

                if (PatientDB.Insert(newPatient))
                    MessageBox.Show("Added successfully", "added", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }

        private void FormPatientAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
