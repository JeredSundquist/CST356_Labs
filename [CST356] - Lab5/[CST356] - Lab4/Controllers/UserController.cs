using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _CST356____Lab4.Data;
using _CST356____Lab4.Repositories;
using _CST356____Lab4.Data.Entities;
using _CST356____Lab4.Models.View;

namespace _CST356____Lab4.Controllers
{
    public class UserController : Controller
    {
        //CREATE: GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //CREATE: POST
        [HttpPost]//<---http get end point
        public ActionResult Create(UserViewModel userViewModel)
        {
            //var db = new AppDbContext();
            var lb5Db = new UserPetRepository();

            if (ModelState.IsValid)
            {
                var user = MapToUser(userViewModel);

                //db.Users.Add(user);
                lb5Db.AddSaveUser(user);

                //db.SaveChanges();//<---VERY IMPORTANT: Updates DB

                return RedirectToAction("List");
            }
            else
                return View();
        }

        //LIST
        public ActionResult List()
        {
            //var db = new AppDbContext();
            var lb5Db = new UserPetRepository();

            var userViewModels = new List<UserViewModel>();

            var users = lb5Db.GetUsers();

            foreach (var user in /*db.Users*/users)
            {
                var userViewModel = MapToUserViewModel(user);
                userViewModels.Add(userViewModel);
            }

            //var users = userViewModels;

            return View(userViewModels);
        }

        //MAP TO USER
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

        //MAP USER VIEW MODEL
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

        //DETAILS
        public ActionResult Details (int id)
        {
            var db = new AppDbContext();

            var userViewModel = new UserViewModel();

            var user = db.Users.Find(id);

            userViewModel = MapToUserViewModel(user);

            return View(userViewModel);
        }

        //DELETE
        public ActionResult Delete(int id)
        {
            var db = new AppDbContext();

            var user = db.Users.Find(id);

            db.Users.Remove(user);

            db.SaveChanges();//<---VERY IMPORTANT: Updates DB

            return RedirectToAction("List");
        }

        //EDIT: GET
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new AppDbContext();

            var userViewModel = new UserViewModel();

            var user = db.Users.Find(id);

            userViewModel = MapToUserViewModel(user);

            return View(userViewModel);
        }

        //EDIT: POST
        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            var db = new AppDbContext();

            var user = db.Users.Find(userViewModel.Id);

            user.FirstName = userViewModel.FirstName;
            user.MiddleName = userViewModel.MiddleName;
            user.LastName = userViewModel.LastName;
            user.EmailAddress = userViewModel.EmailAddress;
            user.DateOfBirth = userViewModel.DOB;
            user.YearsInSchool = userViewModel.YearsInSchool;
            user.FavoriteColor = userViewModel.FavoriteColor;

            db.SaveChanges();//<---VERY IMPORTANT: Updates DB

            return RedirectToAction("List");
        }
    }
}