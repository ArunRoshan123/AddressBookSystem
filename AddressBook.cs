using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();

        public void add_details()
        {
            Console.WriteLine("Enter the first name :");
            string fname = Console.ReadLine();
            string pattern1 = "^[A-Z][a-zA-Z]+$";
            while (!Regex.IsMatch(fname, pattern1))
            {
                Console.WriteLine("Invalid first name");
                fname = Console.ReadLine();

            }
            Console.WriteLine("Enter the last name : ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter the email : ");
            string email = Console.ReadLine();
            string pattern2 = "^[a-zA-Z0-9]*@[a-z]+[.][a-z]{1,3}$";
            while (!Regex.IsMatch(email, pattern2))
            {

                Console.WriteLine("Email not valid, Enter Email Again");
                email = Console.ReadLine();

            }

            Console.WriteLine("Enter the zipCode : ");
            string zipcode = Console.ReadLine();
            string pattern3 = "^[0-9]+$";
            while (!Regex.IsMatch(zipcode, pattern3))
            {

                Console.WriteLine("Invalid Zipcode, Enter Zipcode Again");
                zipcode = Console.ReadLine();

            }
            Console.WriteLine("Enter the city : ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter the state : ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter the phone number : ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the address : ");
            string address = Console.ReadLine();

            Contact newcon = new Contact(fname, lname, phonenumber, email, zipcode, address, state, city);

            contacts.Add(newcon);
        }

        public void display()
        {
            for (int i = 0; i < contacts.Count; i++)
            {

                Console.WriteLine();
                Console.WriteLine("First Name :" + contacts[i].Firstname);
                Console.WriteLine("Last Name :" + contacts[i].Lastname);
                Console.WriteLine("Phone Number :" + contacts[i].Phonenumber);
                Console.WriteLine("Email :" + contacts[i].Email);
                Console.WriteLine("Address :" + contacts[i].Zipcode);
                Console.WriteLine("City :" + contacts[i].Address);
                Console.WriteLine("State :" + contacts[i].Cityname);
                Console.WriteLine("ZipCode :" + contacts[i].State);

            }
        }

        public void edit_contact(string name)
        {
            int flag = 0;
            int found = 0;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Firstname == name)
                {
                    found = 1;
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine("Select an option");
                        Console.WriteLine("1. First Name\n2. Last Name\n3. Phone Number\n4. Email\n5. Address\n6. City\n7. State\n8. ZipCode\n9. Done\n");
                        int n = Convert.ToInt32(Console.ReadLine());

                        switch (n)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Enter the new first name :");
                                contacts[i].Firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Enter the new last name : ");
                                contacts[i].Lastname = Console.ReadLine();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Enter the new phone number : ");
                                contacts[i].Phonenumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Enter the new email : ");
                                contacts[i].Email = Console.ReadLine();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Enter the new address : ");
                                contacts[i].Address = Console.ReadLine();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Enter the new city : ");
                                contacts[i].Cityname = Console.ReadLine();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("Enter the new state : ");
                                contacts[i].State = Console.ReadLine();
                                break;
                            case 8:
                                Console.Clear();
                                Console.WriteLine("Enter the new zipCode : ");
                                contacts[i].Zipcode = Console.ReadLine();
                                break;
                            case 9:
                                Console.WriteLine("Edited");
                                flag = 1;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine();
                    } while (flag == 0);
                }
            }
            if (found == 0)
            {
                Console.WriteLine("The given name is not avaiable");
                Thread.Sleep(2000);
            }
        }

        public void delete_contact(string name)
        {
            int flag = 0;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Firstname == name)
                {
                    flag = 1;
                    contacts.Remove(contacts[i]);
                    Console.WriteLine("The given contact detail is removed");
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("The given contact detail is not avaiable in address book");
            }
        }
    }
}
