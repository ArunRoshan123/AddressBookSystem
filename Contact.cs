using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Contact
    {
        private string firstname;
        private string lastname;
        private long phonenumber;
        private string email;
        private string zipcode;
        private string address;
        private string cityname;
        private string state;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public long Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Cityname
        {
            get { return cityname; }
            set { cityname = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Contact(string fname, string lname, long pnum, string email, string Zipcode, string addr, string sta, string City)
        {
            this.Firstname = fname;
            this.Lastname = lname;
            this.Phonenumber = pnum;
            this.Email = email;
            this.Zipcode = Zipcode;
            this.Address = addr;
            this.State = sta;
            this.Cityname = City;
        }
    }
}
