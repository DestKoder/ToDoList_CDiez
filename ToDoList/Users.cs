using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Users
    {
        public List<User> users { get; set; } = new List<User>();

        public User tryAuth(String login, String password)
        {
            foreach(User user in users)
            {
                if(user.Login.Equals(login) && user.Password.Equals(password))
                {
                    return user;
                }
            }
            return null;
        }

        internal void addUser(User user)
        {
            users.Add(user);
        }
    }
}
