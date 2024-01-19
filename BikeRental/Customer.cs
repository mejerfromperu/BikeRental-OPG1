using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    internal class Customer
    {
        public string _name;
        public string _adress;
        public string _phone;
        public int _studentId;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        Customer()
        {
            _name = "";
            _adress = "";
            _phone = "";
            _studentId = 0;
        }

        Customer(string name, string adress, string phone, int studentId)
        {
            _name = name;
            _adress = adress;
            _phone = phone;
            _studentId = studentId;

        }
    }
}
