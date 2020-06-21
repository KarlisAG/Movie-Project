using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Movie
{
    class Logic
    {
        private int userID;
        public String username;

        public void setuserID(int a)
        {
            userID = a;
        }

        public int getuserID()
        {
            return userID;
        }

        public void setUsername(String a)
        {
            username = a;
        }

        public String getUsername()
        {
            return username;
        }

    }
}
