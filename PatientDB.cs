using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace AE_Clinica
{
    class PatientDB
    {
        public static Patient select(string id)
        {
            Patient P = null;
            string sql = "select Name, Address, ID, Length, Weight, phoneNumber, Birthday " +
               "from Patient " +
               "where (ID= '" + id + "')";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string name, address, length, weight, phoneNumber;
                DateTime birthday;
                name = ds.Tables[0].Rows[0][0].ToString();
                address = ds.Tables[0].Rows[0][1].ToString();
                length = ds.Tables[0].Rows[0][3].ToString();
                weight = ds.Tables[0].Rows[0][4].ToString();
                phoneNumber = ds.Tables[0].Rows[0][5].ToString();
                birthday = DateTime.Parse(ds.Tables[0].Rows[0][6].ToString());
                P = new Patient(name, address, id, length, weight, phoneNumber, birthday);
            }
            return P;
        }
        public static List<Patient> SelectAllPatient()
        {
            List<Patient> lst = new List<Patient>();
            string sql = "select Name, Address, ID, Length, Weight, phoneNumber, Birthday " +
               "from Patients ";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string name, id, address, length, weight, phoneNumber;
                DateTime birthday;

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    name = ds.Tables[0].Rows[i][0].ToString();
                    address = ds.Tables[0].Rows[i][1].ToString();
                    id = ds.Tables[0].Rows[i][2].ToString();
                    length = ds.Tables[0].Rows[i][3].ToString();
                    weight = ds.Tables[0].Rows[i][4].ToString();
                    phoneNumber = ds.Tables[0].Rows[i][5].ToString();
                    birthday = DateTime.Parse(ds.Tables[0].Rows[i][6].ToString());
                    Patient P = new Patient(name, address, id, length, weight, phoneNumber, birthday);
                    lst.Add(P);
                }
            }
            return lst;
        }
        public static bool Delete(string id)
        {
            string sql = "DELETE FROM Patients WHERE (ID = '" + id + "')";
            Connector c = new Connector();
            int n = c.RunUpdateInsertDelete(sql);
            return n > 0;
        }
        public static bool Update(Patient P1, Patient P2)
        {
            string sql = "UPDATE [Patients] " +
                         "SET [Name]='" + P2.Name + "', [Address]='" + P2.Address + "', [ID]='" + P2.Id + "', [Length]='" + P2.Length + "', [Weight] = '" + P2.Weight + "', [phoneNumber] = '" + P2.Phonenumber + "', [Birthday] = '" + P2.Birthday.ToString() + "' " +
                         "WHERE([ID]='" + P1.Id + "')";
            Connector c = new Connector();
            int n = c.RunUpdateInsertDelete(sql);
            return n > 0;
        }
        public static bool Insert(Patient P)
        {
            string sql = "INSERT INTO [Patients] ([Name], [Address], [ID], [Length], [weight], [phoneNumber], [Birthday]) " +
                         "VALUES ('" + P.Name + "',  '" + P.Address + "', '" + P.Id + "', '" + P.Length + "', '" + P.Weight + "', '" + P.Phonenumber + "', '" + P.Birthday.ToString() + "')";
            Connector c = new Connector();
            int n = c.RunUpdateInsertDelete(sql);
            return n > 0;
        }
    }
}
