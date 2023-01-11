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
    public partial class FormPatientsDetails : Form
    {
        private int current;
        private List<Patient> lst;
        private Patient  currentPatient;

        public FormPatientsDetails()
        {
            InitializeComponent();
            this.current = 0;
            currentPatient = null;
        }
        public FormPatientsDetails(Patient P)
        {
            InitializeComponent();
            currentPatient = P;
        }
        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPatientsDetails_Load(object sender, EventArgs e)
        {
            lst = PatientDB.SelectAllPatient();
            LoadPatient();
            CheckButtons();
        }

        private void LoadPatient()
        {
            if (lst.Count != 0)
            {

                Patient P = lst[current];
                textBoxName.Text = P.Name;
                textBoxAddress.Text = P.Address;
                textBoxID.Text = P.Id;
                textBoxLength.Text = P.Length;
                textBoxWeight.Text = P.Weight;
                textBoxPhoneNumber.Text = P.Phonenumber;
                dateTimePickerBirthday.Value = P.Birthday;
                textBoxName.Visible = true;
                textBoxAddress.Visible = true;
                textBoxID.Visible = true;
                textBoxLength.Visible = true;
                textBoxWeight.Visible = true;
                textBoxPhoneNumber.Visible = true;
                dateTimePickerBirthday.Visible = true;
            }
            else
            {
                labelEmpty.Text = "There are no patients";
                textBoxName.Visible = false;
                textBoxAddress.Visible = false;
                textBoxID.Visible = false;
                textBoxLength.Visible = false;
                textBoxWeight.Visible = false;
                textBoxPhoneNumber.Visible = false;
                dateTimePickerBirthday.Visible = false;
            }
            
        }
        private void CheckButtons()
        {
            if (current == 0)
            {
                buttonPrevious.Enabled = false;
                buttonNext.Enabled = false;
            }

            else
            {
                buttonPrevious.Enabled = true;
                buttonNext.Enabled = true;
            }

            if (current == lst.Count - 1)
            {
                buttonNext.Enabled = false;
                buttonLast.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
                buttonLast.Enabled = true;
            }
            if (lst.Count > 0)
                buttonDelete.Enabled = true;
            else
                buttonDelete.Enabled = false;

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

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            current = 0;
            Patient P = lst[current];
            LoadPatient();
            CheckButtons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            current++;
            Patient P = lst[current];
            LoadPatient();
            CheckButtons();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            current--;
            Patient P = lst[current];
            LoadPatient();
            CheckButtons();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            current = lst.Count - 1;
            Patient P = lst[current];
            LoadPatient();
            CheckButtons();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string currentId = lst[current].Id;
            PatientDB.Delete(currentId);
            lst = PatientDB.SelectAllPatient();
            current = 0;
            MessageBox.Show("Deleted", "Message Box");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int number;
            bool success = int.TryParse(textBoxPhoneNumber.Text, out number);
            if (success)
            {
                Patient newPatient = new Patient(textBoxName.Text,
                                                 textBoxAddress.Text,
                                                 textBoxID.Text,
                                                 textBoxLength.Text,
                                                 textBoxWeight.Text,
                                                 textBoxPhoneNumber.Text,
                                                 dateTimePickerBirthday.Value);
                if (Program.currentDoctor != null)
                    if (PatientDB.Update(lst[current], newPatient))

                    {
                        Program.currentPatient = newPatient;
                        MessageBox.Show("Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else
                labelError.Text = "The phone number must be a valid number";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form f = new FormPatientAdd();
            f.Show();
            this.Close();
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
    }
}
