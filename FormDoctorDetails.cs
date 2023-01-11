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
    public partial class FormDoctorDetails : Form
    {
        bool sidebarExpand;
        public FormDoctorDetails()
        {
            InitializeComponent();
        }

        private void FormDoctorDetails_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add("Name", Program.currentDoctor.Name);
            dataGridView.Rows.Add("Address", Program.currentDoctor.Address);
            dataGridView.Rows.Add("Specialty", Program.currentDoctor.Specialty);
            dataGridView.Rows.Add("ID", Program.currentDoctor.Id);
            dataGridView.Rows.Add("phoneNumber", Program.currentDoctor.Phonenumber);
            dataGridView.Rows.Add("Birthdate", Program.currentDoctor.Birthdate);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.currentDoctor = null;
            Form f = new MainPage();
            f.Show();
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Form f = new FormDoctorUpdate();
            f.Show();
            this.Close();
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            Form f = new FormPatientsDetails();
            f.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
     
    
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Form f = new FormReports();
            f.Show();
            this.Close();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            Form f = new FormRoom();
            f.Show();
            this.Close();
        }
    }
}
