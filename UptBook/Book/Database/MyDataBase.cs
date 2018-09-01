using System;
using Book.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Database
{
    public static class MyDataBase
    {
         static void Database()
        {
            Users = new List<User>();
            User me = new User();
            me.Username = "Admin";
            me.Password = "123";
            Users.Add(me);
        }

        public static List<User> Users { get; set; }
        public static List<Books> Books { get; set; }


        public static bool Finduser(User user)
        {
            bool Found = false;
            foreach(User item in Users)
            {
                if(item.Username == user.Username && item.Password == user.Password)
                {
                    Found = true;
                    break;
                }
            }
            return Found;
        }
    }
}
