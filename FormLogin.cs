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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form f = new MainPage();
            f.Show();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string id, password;
            id = textBoxID.Text;
            password = textBoxPassword.Text;

            Doctors D = DoctorsDB.select(id);
            if (D != null)
                if (D.Password == password)
                {
                    Program.currentDoctor = D;
                    Form f = new FormDoctorDetails();
                    f.Show();
                    this.Close();
                }
                labelResult.Text = "No User Found";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
