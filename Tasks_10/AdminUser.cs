using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_10
{
    internal class AdminUser : User
    {
        public AdminUser()
        {

        }
        public AdminUser(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
