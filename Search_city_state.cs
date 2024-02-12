using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Search_city_state
    {
        private List<string> cities;
        public void Add_elements(string fname, string lname, string city, string state, SortedDictionary<string, List<string>> City_or_State, SortedDictionary<string, List<string>> City_or_State1)
        {
            if (!City_or_State.ContainsKey(city))
            {
                cities = new List<string>();
                City_or_State[city] = cities;
                cities.Add(fname + " " + lname);
            }
            else
            {
                cities = City_or_State[city];
                cities.Add(fname + " " + lname);
            }
            if (!City_or_State1.ContainsKey(state))
            {
                cities = new List<string>();
                City_or_State1[state] = cities;
                cities.Add(fname + " " + lname);
            }
            else
            {
                cities = City_or_State1[state];
                cities.Add(fname + " " + lname);
            }
        }
        public void Edit_firstname_dictionary(string new_fname, string fname, string lname, string city, string state, SortedDictionary<string, List<string>> City_or_State, SortedDictionary<string, List<string>> City_or_State1)
        {
            cities = City_or_State[city];
            cities.Remove(fname + " " + lname);
            cities.Add(new_fname + " " + lname);
            cities = City_or_State1[state];
            cities.Remove(fname + " " + lname);
            cities.Add(new_fname + " " + lname);
        }
        public void Edit_lastname_dictionary(string new_lname, string fname, string lname, string city, string state, SortedDictionary<string, List<string>> City_or_State, SortedDictionary<string, List<string>> City_or_State1)
        {
            cities = City_or_State[city];
            cities.Remove(fname + " " + lname);
            cities.Add(fname + " " + new_lname);
            cities = City_or_State1[state];
            cities.Remove(fname + " " + lname);
            cities.Add(fname + " " + new_lname);
        }
        public void Edit_city_dictionary(string new_city, string fname, string lname, string city, SortedDictionary<string, List<string>> City_or_State)
        {
            if (city != new_city)
            {
                cities = City_or_State[city];
                cities.Remove(fname + " " + lname);
                if (!City_or_State.ContainsKey(city))
                {
                    cities = new List<string>();
                    City_or_State[new_city] = cities;
                    cities.Add(fname + " " + lname);
                }
                else
                {
                    cities = City_or_State[new_city];
                    cities.Add(fname + " " + lname);
                }
            }
        }
        public void Edit_state_dictionary(string new_state, string fname, string lname, string state, SortedDictionary<string, List<string>> City_or_State)
        {
            if (state != new_state)
            {
                cities = City_or_State[state];
                cities.Remove(fname + " " + lname);
                if (!City_or_State.ContainsKey(new_state))
                {
                    cities = new List<string>();
                    City_or_State[new_state] = cities;
                    cities.Add(fname + " " + lname);
                }
                else
                {
                    cities = City_or_State[new_state];
                    cities.Add(fname + " " + lname);
                }
            }
        }
        public void display(string city_or_state, SortedDictionary<string, List<string>> City_or_State)
        {
            cities = City_or_State[city_or_state];
            Console.WriteLine($"{city_or_state}:\n");
            foreach (string city in cities)
            {
                Console.WriteLine($"{city}");
            }
        }
    }
}