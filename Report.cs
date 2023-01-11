using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_Clinica
{
    class Report
    {
        private DateTime date;
        private string medicamentName;
        private string details;
        private string IDPatient;
        private string IDReport;
        private string RoomN;
        private string IDDoctors;

        public Report(DateTime date, string medicamentName, string details, string IDPatient, string IDReport, string RoomN, string IDDoctors)
        {
            this.date = date;
            this.medicamentName = medicamentName;
            this.details = details;
            this.IDPatient = IDPatient;
            this.IDReport = IDReport;
            this.RoomN = RoomN;
            this.IDDoctors = IDDoctors;
        }

        public DateTime Date { get => date; set => date = value; }
        public string MedicamentName { get => medicamentName; set => medicamentName = value; }
        public string Details { get => details; set => details = value; }
        public string IDPatient1 { get => IDPatient; set => IDPatient = value; }
        public string IDReport1 { get => IDReport; set => IDReport = value; }
        public string RoomN1 { get => RoomN; set => RoomN = value; }
        public string IDDoctors1 { get => IDDoctors; set => IDDoctors = value; }
    }
}
