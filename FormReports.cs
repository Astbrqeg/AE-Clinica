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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReportsDB.SelectAllReports();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form f = new FormDoctorDetails();
            f.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form f = new FormReportAdd();
            f.Show();
            this.Close();
        }
    }
}
