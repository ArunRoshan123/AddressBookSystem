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
                        // exception
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
                        flag = 1;
                        break;
                }
                Console.Clear();
            } while (flag == 0);
        }
    }
}