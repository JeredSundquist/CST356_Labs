using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _CST356____Lab3.Data.Entities;

namespace _CST356____Lab3.Data
{
    public class InMemoryDatabase
    {
        //list of users; used by inMemoryDatabase
        public static List<User> Users = new List<User>();
        //used to uniquely identify each created user
        public static int id = 0;

        //increment user id
        public static int NextId()
        {
            return id++;
        }

        //get user by id
        public static User GetDetails(int? id)
        {
            //local variables
            var user = Users.Find(thisUser => thisUser.Id == id);//<---find user by id and instantiate local user

            //return user
            return user;
        }
    }
}