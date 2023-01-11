using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace AE_Clinica
{
    class ReportsDB
    {
        public static Report select(string idreports)
        {
            Report R = null;
            string sql = "select Date, MedicamentName, Details, IDPatient, IDReport, RoomN, IDDoctors " +
               "from Reports " +
               "where (IDReport= '" + idreports + "')";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string MedicamentName, Details, IDPatient, RoomN, IDDoctors;
                DateTime Date;
                Date = DateTime.Parse(ds.Tables[0].Rows[0][0].ToString());
                MedicamentName = ds.Tables[0].Rows[0][1].ToString();
                Details = ds.Tables[0].Rows[0][2].ToString();
                IDPatient = ds.Tables[0].Rows[0][3].ToString();
                RoomN = ds.Tables[0].Rows[0][5].ToString();
                IDDoctors = ds.Tables[0].Rows[0][6].ToString();
                R = new Report(Date, MedicamentName, Details, IDPatient, idreports, RoomN, IDDoctors);
            }
            return R;
        }
        public static List<Report> SelectAllReports()
        {
            List<Report> lst = new List<Report>();
            string sql = "select Date, MedicamentName, Details, IDPatient, IDReport, RoomN, IDDoctors " +
               "from Reports ";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string MedicamentName, Details, IDPatient, IDReport, RoomN, IDDoctors;
                DateTime Date;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Date = DateTime.Parse(ds.Tables[0].Rows[i][0].ToString());
                    MedicamentName = ds.Tables[0].Rows[i][1].ToString();
                    Details = ds.Tables[0].Rows[i][2].ToString();
                    IDPatient = ds.Tables[0].Rows[i][3].ToString();
                    IDReport = ds.Tables[0].Rows[i][4].ToString();
                    RoomN = ds.Tables[0].Rows[i][5].ToString();
                    IDDoctors = ds.Tables[0].Rows[i][6].ToString();
                    Report R = new Report(Date, MedicamentName, Details, IDPatient, IDReport, RoomN, IDDoctors);
                    lst.Add(R);
                }
            }
            return lst;
        }
        public static bool Insert(Report R)
        {
            string sql = "INSERT INTO [Reports] ([Date], [MedicamentName], [Details], [IDPatient], [IDReport], [RoomN], [IDDoctors]) " +
                         "VALUES ('" + R.Date.ToString() + "',  '" + R.MedicamentName + "', '" + R.Details + "', '" + R.IDPatient1 + "', '" + R.IDReport1 + "', '" + R.RoomN1 + "', '" + R.IDDoctors1 + "')";
            Connector c = new Connector();
            int n = c.RunUpdateInsertDelete(sql);
            return n > 0;
        }
    }
}
