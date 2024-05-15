using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITraining
{
    internal class Users
    {
        private List<User> userlist;

        public List<User> UserList
        {
            get
            {
                return userlist;
            }

            set
            {
                userlist = value;
            }
        }
        public Users()
        {
            UserList = new List<User>();
        }

        public void addUser(User user)
        {

            UserList.Add(user);
        }

        public void displayUsers()
        {
            if (UserList.Count == 0)
            {
                Console.WriteLine("No users found");
                return;
            }
            foreach (User user in userlist)
            {
                Console.WriteLine(user.ToString()+"\n");
                
            }
        }

    }
}
