using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_7
{
    internal class user
    {

		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set 
			{  
                if(value.Length >= 4 && value.Length <= 10)
                {
                    _firstName = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

			}
		}

        private string _lastName;

		public string LastName

        {
            get { return _lastName; }
            set
            {
                if (value.Length >= 6 && value.Length <= 14)
                {
                    _lastName = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private string _email;

		public string Email

        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private string _password;

		public string Password

        {
            get { return _password; }
            set
            {
                if (value.Length >= 8 && value.Length <= 14)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private byte _age;

		public byte Age

        {
            get { return _age; }
            set
            {
                if (value >= 18 )
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private string _number;

		public string Number

        {
            get { return _number; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _number = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private string _eyeColor;

		public string EyeColor

        {
            get { return _eyeColor; }
            set
            {
                if (value != "blue")
                {
                    _eyeColor = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private int _height;

		public int Height

        {
            get { return _height; }
            set
            {
                if (value > 180 && value < 250)
                {
                    _height= value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private int _weight;

		public int Weight

        {
            get { return _weight; }
            set
            {
                if (value > 110)
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }
        }

        private string _gender;

		public string Gender

        {
            get { return _gender; }
            set
            {
                if (value != "other")
                {
                    _gender = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
