using Address_Book_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Contact
    {
        private string first_name;
        private string last_name;
        private long phone_number;
        private string email;
        private string address;
        private string city;
        private string state;
        private int zip;

        public void set_firstname(string first)
        {
            this.first_name = first;
        }
        public string get_firstname()
        {
            return this.first_name;
        }
        public void set_lastname(string last)
        {
            this.last_name = last;
        }
        public string get_lastname()
        {
            return this.last_name;
        }
        public long get_phone()
        {
            return this.phone_number;
        }
        public void set_phone(long phone)
        {
            this.phone_number = phone;
        }
        public void set_email(string mail)
        {
            this.email = mail;
        }
        public string get_email()
        {
            return this.email;
        }
        public void set_address(string address)
        {
            this.address = address;
        }
        public string get_address()
        {
            return this.address;
        }
        public void set_city(string city)
        {
            this.city = city;
        }
        public string get_city()
        {
            return this.city;
        }
        public void set_state(string state)
        {
            this.state = state;
        }
        public string get_state()
        {
            return this.state;
        }
        public void set_zip(int zip)
        {
            this.zip = zip;
        }
        public int get_zip()
        {
            return this.zip;
        }
        public void display()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }
        public Contact(string first, string last, long phone, string email, string address, string city, string state, int zip)
        {
            this.first_name = first;
            this.last_name = last;
            this.phone_number = phone;
            this.email = email;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
    }
}