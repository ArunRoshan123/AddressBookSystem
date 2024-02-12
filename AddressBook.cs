using System;
using Address_Book_System;
using System.Collections.Generic;

namespace Address_Book_System
{
    class AddressBookMain
    {
        private List<Contact> list;
        private HashSet<string> names;
        public AddressBookMain(string name1, SortedDictionary<string, List<Contact>> contactlist, SortedDictionary<string, HashSet<String>> hash)
        {
            list = new List<Contact>();
            names = new HashSet<string>();
            contactlist[name1] = list;
            hash[name1] = names;
        }
        public int contacts()
        {
            return list.Count;
        }
        public void switching(string name, SortedDictionary<string, List<Contact>> contactlist, SortedDictionary<string, HashSet<String>> hash)
        {
            list = contactlist[name];
            names = hash[name];
        }
        public void add_details(SortedDictionary<string, List<string>> City_or_State1, SortedDictionary<string, List<string>> City_or_State, Search_city_state search)
        {
            Regex_Exception_Handling reh = new Regex_Exception_Handling();
            string name, first_name, last_name, email, phone_number, address, city, state, zip;
            int variable;
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("First Name : ");
                    first_name = Console.ReadLine();
                    variable = reh.check_firstName(first_name);
                    if (variable == 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                    }

                } while (true);
                do
                {
                    Console.Write("Last Name : ");
                    last_name = Console.ReadLine();
                    variable = reh.check_lastName(last_name);
                    if (variable == 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write($"First Name : {first_name}\n");
                    }
                } while (true);
                name = first_name + " " + last_name;
                name = name.ToUpper();
                if (!names.Contains(name))
                {
                    names.Add(name);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The specified Name exist in the Address Book...");
                    Console.ReadKey();
                }
            } while (names.Contains(name));
            do
            {
                Console.Write("Email : ");
                email = Console.ReadLine();
                variable = reh.check_email(email);
                if (variable == 1)
                {
                    break;
                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write($"First Name : {first_name}\n" +
                                  $"Last Name : {last_name}\n");
                }
            } while (true);
            do
            {
                Console.Write("Phone Number : ");
                phone_number = Console.ReadLine();
                variable = reh.check_phoneNumber(phone_number);
                if (variable == 1)
                {
                    break;
                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write($"First Name : {first_name}\n" +
                                  $"Last Name : {last_name}\n" +
                                  $"Email : {email}\n");
                }
            } while (true);
            Console.Write("Address : ");
            address = Console.ReadLine();
            do
            {
                Console.Write("City : ");
                city = Console.ReadLine();
                variable = reh.check_city(city);
                if (variable == 1)
                {
                    break;
                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write($"First Name : {first_name}\n" +
                                  $"Last Name : {last_name}\n" +
                                  $"Email : {email}\n" +
                                  $"Phone Number : {phone_number}\n" +
                                  $"Address : {address}\n");
                }
            } while (true);
            do
            {
                Console.Write("State : ");
                state = Console.ReadLine();
                variable = reh.check_State(state);
                if (variable == 1)
                {
                    break;
                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write($"First Name : {first_name}\n" +
                                  $"Last Name : {last_name}\n" +
                                  $"Email : {email}\n" +
                                  $"Phone Number : {phone_number}\n" +
                                  $"Address : {address}\n" +
                                  $"City : {city}\n");
                }
            } while (true);
            do
            {
                Console.Write("ZipCode : ");
                zip = Console.ReadLine();
                variable = reh.check_zip(zip);
                if (variable == 1)
                {
                    break;
                }
                else
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write($"First Name : {first_name}\n" +
                                  $"Last Name : {last_name}\n" +
                                  $"Email : {email}\n" +
                                  $"Phone Number : {phone_number}\n" +
                                  $"Address : {address}\n" +
                                  $"City : {city}\n" +
                                  $"State : {state}\n");
                }
            } while (true);
            Contact contact = new Contact(first_name, last_name, (long)Convert.ToInt64(phone_number), email, address, city, state, (int)Convert.ToInt32(zip));
            list.Add(contact);
            search.Add_elements(first_name, last_name, city, state, City_or_State, City_or_State1);
            Console.Clear();
            Console.WriteLine("Contact Added Successfully ...");
            Console.ReadKey();
        }
        public void display(Contact contact)
        {
            Console.WriteLine($"First Name : {contact.get_firstname()}");
            Console.WriteLine($"Last Name : {contact.get_lastname()}");
            Console.WriteLine($"Phone Number : {contact.get_phone()}");
            Console.WriteLine($"Email : {contact.get_email()}");
            Console.WriteLine($"Address : {contact.get_address()}");
            Console.WriteLine($"City : {contact.get_city()}");
            Console.WriteLine($"State : {contact.get_state()}");
            Console.WriteLine($"ZipCode : {contact.get_zip()}");
        }
        public void display1()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Contact : {i + 1}\n");
                Console.WriteLine($"First Name : {list[i].get_firstname()}");
                Console.WriteLine($"Last Name : {list[i].get_lastname()}");
                Console.WriteLine($"Phone Number : {list[i].get_phone()}");
                Console.WriteLine($"Email : {list[i].get_email()}");
                Console.WriteLine($"Address : {list[i].get_address()}");
                Console.WriteLine($"City : {list[i].get_city()}");
                Console.WriteLine($"State : {list[i].get_state()}");
                Console.WriteLine($"ZipCode : {list[i].get_zip()}\n");
            }
        }
        public void Edit_Contact(string email_check, Search_city_state search, SortedDictionary<string, List<string>> City_or_State, SortedDictionary<string, List<string>> City_or_State1)
        {
            int flag = 0, n, found = 0;
            int variable;
            Regex_Exception_Handling reh = new Regex_Exception_Handling();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].get_email() == email_check)
                {
                    found = 1;
                    do
                    {
                        display(list[i]);
                        Console.WriteLine();
                        Console.WriteLine("Enter the option to edit : ");
                        Console.WriteLine("1. First Name\n2. Last Name\n3. Phone Number\n4. Email\n5. Address\n6. City\n7. State\n8. ZipCode\n9. Done\n");
                        n = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("New First Name : ");
                                    string first_name = Console.ReadLine();
                                    variable = reh.check_firstName(first_name);
                                    if (variable == 1)
                                    {
                                        search.Edit_firstname_dictionary(first_name, list[i].get_firstname(), list[i].get_lastname(), list[i].get_city(), list[i].get_state(), City_or_State, City_or_State1);
                                        list[i].set_firstname(first_name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 2:
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("New Last Name : ");
                                    string last_name = Console.ReadLine();
                                    variable = reh.check_lastName(last_name);
                                    if (variable == 1)
                                    {
                                        search.Edit_lastname_dictionary(last_name, list[i].get_firstname(), list[i].get_lastname(), list[i].get_city(), list[i].get_state(), City_or_State, City_or_State1);
                                        list[i].set_lastname(last_name);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 3:
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("New Phone number : ");
                                    long phone_number = Convert.ToInt64(Console.ReadLine());
                                    string phone = phone_number.ToString();
                                    variable = reh.check_phoneNumber(phone);
                                    if (variable == 1)
                                    {
                                        list[i].set_phone(phone_number);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 4:
                                Console.Clear();
                                do
                                {
                                    Console.Write("Email : ");
                                    string email = Console.ReadLine();
                                    variable = reh.check_email(email);
                                    if (variable == 1)
                                    {
                                        list[i].set_email(email);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Enter the New Address : ");
                                string address = Console.ReadLine();
                                list[i].set_address(address);
                                break;
                            case 6:
                                Console.Clear();
                                do
                                {
                                    Console.Write("City : ");
                                    string city = Console.ReadLine();
                                    variable = reh.check_city(city);
                                    if (variable == 1)
                                    {
                                        search.Edit_city_dictionary(city, list[i].get_firstname(), list[i].get_lastname(), list[i].get_city(), City_or_State);
                                        list[i].set_city(city);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 7:
                                Console.Clear();
                                do
                                {
                                    Console.Write("State : ");
                                    string state = Console.ReadLine();
                                    variable = reh.check_State(state);
                                    if (variable == 1)
                                    {
                                        search.Edit_state_dictionary(state, list[i].get_firstname(), list[i].get_lastname(), list[i].get_state(), City_or_State1);
                                        list[i].set_state(state);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 8:
                                Console.Clear();
                                do
                                {
                                    Console.Write("ZipCode : ");
                                    int zip = Convert.ToInt32(Console.ReadLine());
                                    string zip1 = Convert.ToString(zip);
                                    variable = reh.check_zip(zip1);
                                    if (variable == 1)
                                    {
                                        list[i].set_zip(zip);
                                        break;
                                    }
                                    else
                                    {
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                } while (true);
                                break;
                            case 9:
                                flag = 1;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("Edited ...");
                        Console.ReadKey();
                        Console.Clear();
                    } while (flag == 0);

                }
            }
            if (found == 0)
            {
                Console.WriteLine("The Given Name is not there in the contact list");
                Console.ReadKey();
            }
        }
        public void Delete_Contact(string email_check)
        {
            char ch;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].get_email() == email_check)
                {
                    display(list[i]);
                    Console.WriteLine();
                    Console.WriteLine($"Are you sure of deleteing {email_check}\'s contact (Y/N)");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'Y' || ch == 'y')
                    {
                        list.Remove(list[i]);
                        Console.WriteLine("Contact is Deleted ...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Contact Not Deleted");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}