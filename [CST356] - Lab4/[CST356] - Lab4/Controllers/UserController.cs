using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _CST356____Lab4.Data;
using _CST356____Lab4.Data.Entities;
using _CST356____Lab4.Models.View;

namespace _CST356____Lab4.Controllers
{
    public class UserController : Controller
    {
        //GET: User
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //POST: User
        [HttpPost]//<---http get end point
        public ActionResult Create(UserViewModel userViewModel)
        {
            var db = new AppDbContext();
            
            if (ModelState.IsValid)
            {
                var user = MapToUser(userViewModel);

                db.Users.Add(user);

                db.SaveChanges();

                return RedirectToAction("List");
            }
            else
                return View();
        }

        //GET: List of Users
        public ActionResult List()
        {
            var db = new AppDbContext();
     
            var userViewModels = new List<UserViewModel>();
       
            foreach (var user in db.Users)
            {
                var userViewModel = MapToUserViewModel(user);
                userViewModels.Add(userViewModel);
            }

            var users = userViewModels;

            return View(users);
        }

        //Map to User
        private User MapToUser(UserViewModel userViewModel)
        {
            return new User
            {
                Id = userViewModel.Id,
                FirstName = userViewModel.FirstName,
                MiddleName = userViewModel.MiddleName,
                LastName = userViewModel.LastName,
                EmailAddress = userViewModel.EmailAddress,
                DateOfBirth = userViewModel.DOB,
                YearsInSchool = userViewModel.YearsInSchool,
                FavoriteColor = userViewModel.FavoriteColor
            };
        }

        //Map to User View Model
        private UserViewModel MapToUserViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress,
                DOB = user.DateOfBirth,
                YearsInSchool = user.YearsInSchool,
                FavoriteColor = user.FavoriteColor
            };
        }

        public ActionResult Details (int id)
        {
            var db = new AppDbContext();

            var userViewModel = new UserViewModel();

            var user = db.Users.Find(id);

            return View(user);

        }
    }
}