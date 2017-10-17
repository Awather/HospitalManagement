using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;
using System.Data;

namespace HospitalManagement
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private char gender;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char  Gender { get; set; }

    }

    public class Staff : Person
    {
        private string roles;
        private string department;

        public string Roles { get; set; }
        public string Department { get; set; }

    }

    public class Patient : Person
    {
        private string personNumber;
        private string address;
        private string postalNumber;
        private string city;
        private string phoneNumber;
        private string eMail;

        public Patient(string personNr, string fName, string lName, string adrs, string postalNr, string cit, string phoneNr, string ePost, char sex)
        {
            PersonNumber = personNr;
            FirstName = fName;
            LastName = lName;
            Address = adrs;
            PostalNumber = postalNr;
            City = cit;
            PhoneNumber = phoneNr;
            EMail = ePost;
            Gender = sex;

        }

        public string PersonNumber {get; set;}
        public string Address { get; set; }
        public string PostalNumber { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }


    }
    
}
