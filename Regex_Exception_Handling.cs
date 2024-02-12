using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Address_Book_System
{
    class Regex_Exception_Handling
    {
        public int check_firstName(string first_name)
        {
            string pattern_fname = "^([A-Z][a-z]*)[\\s]*$";
            int flag = 0;
            Regex refn = new Regex(pattern_fname);
            try
            {
                if (!refn.IsMatch(first_name))
                {
                    throw new ArgumentException("\nFirst Name Should Contain atleast 2 characters\n" +
                                                "and First letter should be capital\n");
                }
                else
                {
                    flag = 1;
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
        public int check_lastName(string last_name)
        {
            string pattern_lname = "^([A-Z][A-Za-z]*)[\\s]*$";
            int flag = 0;
            Regex reln = new Regex(pattern_lname);
            try
            {

                if (!reln.IsMatch(last_name))
                {
                    throw new ArgumentException("\nLast Name Should Contain atleast 2 characters\n" +
                                                "and Last letter should be capital\n");
                }
                else
                {
                    flag = 1;
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
        public int check_email(string email)
        {
            string pattern_email = "^[a-zA-Z0-9]{5,15}@(gmail.com|yahoo.com|srmist.edu.in)$";
            int flag = 0;
            Regex re = new Regex(pattern_email);
            try
            {
                if (re.IsMatch(email))
                {
                    flag = 1;
                }
                else
                {
                    throw new ArgumentException("\nInvalid Email ...");
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
        public int check_phoneNumber(string phone_number)
        {
            string pattern_phoneNumber = "^[7-9][0-9]{9}$";
            int flag = 0;
            Regex rep = new Regex(pattern_phoneNumber);
            try
            {
                if (rep.IsMatch(phone_number))
                {
                    flag = 1;
                }
                else
                {
                    throw new ArgumentException("\nInvalid Phone Number ...");
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
        public int check_city(string city)
        {
            string pattern_city = "^[A-Z][a-z]*$";
            int flag = 0;
            Regex rec = new Regex(pattern_city);
            try
            {
                if (rec.IsMatch(city))
                {
                    flag = 1;
                }
                else
                {
                    throw new ArgumentException("Starting Letter should be Capital ...");
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
        public int check_State(string state)
        {
            string pattern_state = "^[A-Z][a-zA-Z]*$";
            int flag = 0;
            Regex res = new Regex(pattern_state);
            try
            {
                if (res.IsMatch(state))
                {
                    flag = 1;
                }
                else
                {
                    throw new ArgumentException("Starting Letter should be Capital ...");
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
        public int check_zip(string zip)
        {
            string pattern_zip = "^[0-9]{6}$";
            Regex rez = new Regex(pattern_zip);
            int flag = 0;
            try
            {
                if (rez.IsMatch(zip))
                {
                    flag = 1;
                }
                else
                {
                    throw new ArgumentException("Invalid ZipCode ...");
                }
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine($"{ar.Message}");
            }
            return flag;
        }
    }
}