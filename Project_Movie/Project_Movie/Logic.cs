﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Movie
{
    public class Logic
    {
        private int userID;
        public String username;
        public String USername { get; set; }

        public Logic()
        {

        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public void setuserID(int userID)
        {
            this.userID = userID;
        }

        public int getuserID()
        {
            return userID;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getUsername()
        {
            return username;
        }

    }
}
