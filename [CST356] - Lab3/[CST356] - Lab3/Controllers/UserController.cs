using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _CST356____Lab3.Data;
using _CST356____Lab3.Data.Entities;

namespace _CST356____Lab3.Controllers
{
    public class UserController : Controller
    {      
        // GET User
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST User
        [HttpPost]
        public ActionResult Create(User user)
        {
            //local vriables
            user.Id = InMemoryDatabase.NextId();//<---binds the next id from database to the new user

            //validate entries
            if (ModelState.IsValid)//<---is valid
            {
                InMemoryDatabase.Users.Add(user);//<---post the new user to database with attached id

                return RedirectToAction("List");//<---return the redirect to the list of users
            }
            else//<---not valid
                return View(user);//<---returns the view of current user
        }
        // GET List of Users
        public ActionResult List()
        {
            var listOfUsers = InMemoryDatabase.Users;//<---local variable to store list of users from InMemoryDatabase

            return View(listOfUsers);//<---return this list of users
        }
        // GET User Details
        public ActionResult Details(int id)
        {
            var user = InMemoryDatabase.GetDetails(id);

            return View(user);
        }
    }
}