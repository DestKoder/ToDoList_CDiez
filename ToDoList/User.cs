using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class User
    {

        public String Login { get; set; }
        public String Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public User()
        {

        }
    }
}
