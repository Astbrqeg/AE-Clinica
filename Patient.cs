using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AE_Clinica
{
    public class Patient
    {
        private string name;
        private string address;
        private string id;
        private string length;
        private string weight;
        private string phonenumber;
        private DateTime birthday;

        public Patient(string name, string address, string id, string length, string weight, string phonenumber, DateTime birthday)
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.length = length;
            this.weight = weight;
            this.phonenumber = phonenumber;
            this.birthday = birthday;

        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Id { get => id; set => id = value; }
        public string Length { get => length; set => length = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
    }
}
