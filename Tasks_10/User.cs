using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Tasks_10
{
    internal abstract class User
    {


       
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        private string _password;

       

        public string Password
        {
            get { return _password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }


        }


        public  void LogIn()
        {
            Console.Write("Enter your email: ");

            string mail = Console.ReadLine();


            Console.Write("Enter your password: ");

            string pass = Console.ReadLine();

            if (_email == mail && _password == pass)   
            {
                Console.WriteLine("Autorization good, good");
            }
            else
            {
                Console.WriteLine("email or password is incorect");
            }

        }
        
    }

}
