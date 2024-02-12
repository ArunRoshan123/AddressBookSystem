using Address_Book_System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Address_Book_System

{

    internal class Program
    {
        static void Main(string[] args)

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
        private long zipcode;
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
        public long Zipcode
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
        public Contact(string fname, string lname, long pnum, string email, long Zipcode,string addr, string sta,string City) 
        {
            this.Firstname = fname;
            this.Lastname = lname;
            this.Phonenumber = pnum;
            this.Email = email;
            this.Zipcode = Zipcode;
            this.Zipcode = Zipcode; 
            this.Address = addr;
            this.State = sta;
            this.Cityname = City;
        }
    }

    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();
        public void add_details()
        {
            SortedDictionary<string, List<Contact>> contactlist = new SortedDictionary<string, List<Contact>>();
            SortedDictionary<string, HashSet<String>> hash = new SortedDictionary<string, HashSet<String>>();
            SortedDictionary<string, List<string>> City_or_State = new SortedDictionary<string, List<string>>();
            SortedDictionary<string, List<string>> City_or_State1 = new SortedDictionary<string, List<string>>();
            Search_city_state search = new Search_city_state();
            int option, flag = 0;
            Console.WriteLine("Enter the Owner of the Address Book : ");
            string name1 = Console.ReadLine();
            AddressBookMain addr = new AddressBookMain(name1, contactlist, hash);
            Console.Clear();
            do
            {
                Console.WriteLine("Enter an Option to perform : ");
                Console.WriteLine("1. Add Details\n2. Display Details\n3. Edit a Contact\n4. Delete a Contact\n5. Search a contact\n6. Add a Address Book\n7. Display Address Books\n8. Switch Address Book\n9. Exit\n");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if ((option == 2 || option == 3 || option == 4 || option == 5) && addr.contacts() == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Address Book is empty...");
                    option = 1;
                    Thread.Sleep(3000);
                }
                if (option == 7)
                {
                    if (contactlist.Count < 1)
                    {
                        Console.WriteLine("Switching is not possible for one book ...");
                        Console.ReadKey();
                        option = 5;
                    }
                }
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add Details : \n");
                        Console.WriteLine();
                        addr.add_details(City_or_State1, City_or_State, search);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Diplay details : \n");
                        addr.display1();
                        Console.WriteLine("Press Any Key ...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        addr.display1();
                        Console.WriteLine("Enter the Email of the Contact to be edited : ");
                        string name = Console.ReadLine();
                        Console.Clear();
                        addr.Edit_Contact(name, search, City_or_State, City_or_State1);
                        break;
                    case 4:
                        Console.Clear();
                        addr.display1();
                        Console.WriteLine("Enter the Email of the Contact to be Deleted : ");
                        string name2 = Console.ReadLine();
                        Console.Clear();
                        addr.Delete_Contact(name2);
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Search for contact based on : \n" +
                                      "1. City\n" +
                                      "2. State\n");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)

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
            Console.WriteLine("Enter the last name : ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter the email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the zipCode : ");
            long zipcode = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the city : ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter the state : ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter the phone number : ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the address : ");
            string address = Console.ReadLine();
            
            Contact newcon = new Contact(fname, lname,phonenumber,email,zipcode,address,state,city);
            
            contacts.Add(newcon);        
        }
        
        public void display()
        {   
            for(int i=0;i<contacts.Count;i++)
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
        
            for(int i=0;i < contacts.Count; i++)
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
                                Console.WriteLine("Cities :\n");
                                foreach (KeyValuePair<string, List<string>> pair in City_or_State)
                                {
                                    Console.Write($"{pair.Key}  {pair.Value.Count()} Contacts\n");
                                }
                                Console.WriteLine("\nEnter The City to search :\n");
                                string name3 = Console.ReadLine();
                                if (!City_or_State.ContainsKey(name3))
                                {
                                    Console.WriteLine($"{name3} is not present");
                                }
                                else
                                {
                                    Console.Clear();
                                    search.display(name3, City_or_State);
                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("States :\n");
                                foreach (KeyValuePair<string, List<string>> pair in City_or_State1)
                                {
                                    Console.Write($"{pair.Key}  {pair.Value.Count()} Contacts\n\n");
                                }
                                Console.WriteLine("\nEnter The State to search :\n");
                                name3 = Console.ReadLine();
                                if (!City_or_State1.ContainsKey(name3))
                                {
                                    Console.WriteLine($"{name3} is not present");
                                }
                                else
                                {
                                    Console.Clear();
                                    search.display(name3, City_or_State1);
                                }
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Owner of the New Address Book : ");
                            name1 = Console.ReadLine();
                            if (!contactlist.ContainsKey(name1))
                            {
                                addr = new AddressBookMain(name1, contactlist, hash);
                                Console.Clear();
                                Console.WriteLine("New Address Book Created ...");
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("That Owner already Exists ...");
                            }
                        } while (true);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Address Books : ");
                        foreach (var kvp in contactlist)
                        {
                            if (kvp.Key == name1)
                                Console.Write("> ");
                            else
                                Console.Write("  ");
                            Console.WriteLine($"{kvp.Key} : {kvp.Value.Count} Contacts");
                        }
                        Console.WriteLine("\nPress any key ...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();         //switch is not possible in 1 book and same book
                        do
                        {
                            foreach (var kvp in contactlist)
                            {
                                if (kvp.Key == name1)
                                    Console.Write("> ");
                                else
                                    Console.Write("  ");
                                Console.WriteLine($"{kvp.Key} : {kvp.Value.Count} Contacts");
                            }
                            Console.WriteLine("Enter the name of the Owner to Switch : ");
                            name1 = Console.ReadLine();
                            if (contactlist.ContainsKey(name1))
                            {
                                addr.switching(name1, contactlist, hash);
                                Console.Clear();
                                Console.WriteLine($"Owner Switched to {name1}");
                                Thread.Sleep(2000);
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Owner does not exist ...");
                                Thread.Sleep(2000);
                            }
                        } while (true);

                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Exited");
                        case 4:
                            flags = false;
                            break;

                    }
            }
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
                                contacts[i].Zipcode = Convert.ToInt32(Console.ReadLine());
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
            if(found == 0)
            {
                Console.WriteLine("The given name is not avaiable");
                Thread.Sleep(2000);
            }
        }

        public void delete_contact(string name)
        {
            int flag = 0;

            for(int i=0; i<contacts.Count; i++)
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program.");
            AddressBook obj = new AddressBook();  
            int flag = 0;
            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1.Add Details\n2.Display Details\n3.Edit a contact\n4.Delete\n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Add details:\n");
                        obj.add_details();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Displaying Contact:\n");
                        obj.display();
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter name to edit the details\n");
                        string name = Console.ReadLine();
                        obj.edit_contact(name);
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter name to delete a contact\n");
                        name = Console.ReadLine();
                        obj.delete_contact(name);
                        Thread.Sleep(2000);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Exited");
                        Thread.Sleep(2000);
                        flag = 1;
                        break;
                }
                Console.Clear();
            } while (flag == 0);
            } while(flag == 0);
            Console.ReadLine();
        }
    }
}