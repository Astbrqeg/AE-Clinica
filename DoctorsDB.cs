using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace AE_Clinica
{
    class DoctorsDB
    {
        public static Doctors select(string id)
        {
            Doctors D = null;
            string sql = "select Name, Address, specialty, ID, [PhoneNumber], Birthdate, Password " +
               "from Doctors " +
               "where (ID = '" + id + "')";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {

                DataSet ds = c.returnOledbDataSet(sql);
                string name, password, address, specialty, Phonenumber;
                DateTime birthdate;
                name = ds.Tables[0].Rows[0][0].ToString();
                address = ds.Tables[0].Rows[0][1].ToString();
                specialty = ds.Tables[0].Rows[0][2].ToString();
                Phonenumber = ds.Tables[0].Rows[0][4].ToString();
                birthdate = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());
                password = ds.Tables[0].Rows[0][6].ToString();
                D = new Doctors(name, address, specialty, id, Phonenumber, birthdate, password);
            }
            return D;
        }

        public static List<Doctors> SelectAllDoctors()
        {
            List<Doctors> lst = new List<Doctors>();
            string sql = "select Name, Address, specialty, ID, Phonenumber, Birthdate, password " +
               "from Doctors & nurses ";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string name, id, password, address, specialty, Phonenumber;
                DateTime birthdate;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    name = ds.Tables[0].Rows[i][0].ToString();
                    address = ds.Tables[0].Rows[i][1].ToString();
                    specialty = ds.Tables[0].Rows[i][2].ToString();
                    id = ds.Tables[0].Rows[i][3].ToString();
                    Phonenumber = ds.Tables[0].Rows[i][4].ToString();
                    birthdate = DateTime.Parse(ds.Tables[0].Rows[i][5].ToString());
                    password = ds.Tables[0].Rows[i][6].ToString();
                    Doctors D = new Doctors(name, address, specialty, id, Phonenumber, birthdate, password);
                    lst.Add(D);
                }
            }
            return lst;
        }

        public static bool Update(Doctors w1, Doctors w2)
        {
            string sql = "UPDATE [Doctors] " +
                         "SET [Name]='" + w2.Name + "',  [Address]='" + w2.Address + "', [Specialty]='" + w2.Specialty + "', [ID]='" + w2.Id + "', [Phonenumber]='" + w2.Phonenumber + "', [Birthdate]='" + w2.Birthdate.ToString() + "', [Password]='" + w2.Password + "' " +
                         "WHERE([ID]='" + w1.Id + "')";
            Connector c = new Connector();
            int n = c.RunUpdateInsertDelete(sql);
            return n > 0;
        }
      
    }
}
