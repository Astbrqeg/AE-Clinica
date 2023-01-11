using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AE_Clinica
{
    public partial class FormReportAdd : Form
    {

        public FormReportAdd()
        {
            InitializeComponent();
        }

        private void labelReportID_Click(object sender, EventArgs e)
        {

        }

        private void FormReportAdd_Load(object sender, EventArgs e)
        {
            List<Patient> lst = PatientDB.SelectAllPatient();
            foreach (Patient We in lst)
                comboBoxID.Items.Add(We.Id);

            List<Room> lste = RoomDB.SelectAllRoom();
            foreach (Room Me in lste)
                comboBoxRN.Items.Add(Me.RoomNumber);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
                Report newReport = new Report(dateTimePickerDate.Value,
                                              textBoxMedicamentName.Text,
                                              textBoxDetails.Text,
                                              comboBoxID.Text,
                                              textBoxReportID.Text,
                                              comboBoxRN.Text,
                                              Program.currentDoctor.Id);
            if (ReportsDB.Insert(newReport))
                MessageBox.Show("Added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form f = new FormReports();
            f.Show();
            this.Close();
        }

        private void textBoxPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }

        private void textBoxReportID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }

        private void textBoxRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }

        private void textBoxDoctorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsNumber(ch))
                e.Handled = true;
        }

        private void textBoxPatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
