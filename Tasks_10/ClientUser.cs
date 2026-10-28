using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks_10
{
    internal class ClientUser : User
    {
        public ClientUser()
        {

        }
        public ClientUser(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

       
    }
}
