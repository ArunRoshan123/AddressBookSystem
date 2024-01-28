using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
        class Contact
        {
            public string firstname;
            public string lastname;
            public long phonenumber;
            public string email;
        }
        class AddressBook : Contact 
        {
            public long zipcode;
            public string address;
            public string cityname;
            public string state;

            public void add_details()
            { 
                Console.Write("Enter First Name: ");
                this.firstname = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                this.lastname = Console.ReadLine();

                Console.Write("Enter Address: ");
                this.address = Console.ReadLine();

                Console.Write("Enter City: ");
                this.cityname = Console.ReadLine();

                Console.Write("Enter State: ");
                this.state = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                this.phonenumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter Zip Code: ");
                this.zipcode = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter Email: ");
                this.email = Console.ReadLine();
            }

            public void display()
            {
                Console.WriteLine();
                Console.WriteLine("First Name :" + this.firstname);
                Console.WriteLine("Last Name :" + this.lastname);
                Console.WriteLine("Phone Number :" + this.phonenumber);
                Console.WriteLine("Email :" + this.email);
                Console.WriteLine("Address :" + this.address);
                Console.WriteLine("City :" + this.cityname);
                Console.WriteLine("State :" + this.state);
                Console.WriteLine("ZipCode :" + this.zipcode);
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program.");

            AddressBook obj = new AddressBook();    
            obj.add_details();
            obj.display();
            Console.ReadLine();
        }
    }
}
