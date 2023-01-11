using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE_Clinica
{
    class Doctors
    {
        private string name;
        private string address;
        private string specialty;
        private string id;
        private string phonenumber;
        private DateTime birthdate;
        private string password;

        public Doctors(string name, string address, string specialty, string id, string phonenumber, DateTime birthdate, string password)
        {
            this.name = name;
            this.address = address;
            this.specialty = specialty;
            this.id = id;
            this.phonenumber = phonenumber;
            this.birthdate = birthdate;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Specialty { get => specialty; set => specialty = value; }
        public string Id { get => id; set => id = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Password { get => password; set => password = value; }
    }
}
