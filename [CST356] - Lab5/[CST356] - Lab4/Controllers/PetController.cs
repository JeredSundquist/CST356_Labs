﻿using System;
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
    public class PetController : Controller
    {
        //DEPENDENCY INJECTION
        IUserPetRepository lb5Db;

        public PetController(IUserPetRepository repoInject)
        {
            lb5Db = repoInject;
        }

        //CREATE: GET
        [HttpGet]
        public ActionResult Create(int? userId)
        {
            ViewBag.UserId = userId;

            return View();
        }

        //CREATE: POST
        [HttpPost]//<---http get end point
        public ActionResult Create(PetViewModel petViewModel)
        {
            //var db = new AppDbContext();
            //var lb5Db = new UserPetRepository();

            if (ModelState.IsValid)
            {
                var pet = MapToPet(petViewModel);

                //db.Pets.Add(pet);
                lb5Db.AddSavePet(pet);
                //db.SaveChanges();//<---VERY IMPORTANT: Updates DB

                return RedirectToAction("List", new {UserId = petViewModel.UserId});
            }
            else
                return View();
        }

        //LIST
        public ActionResult List(int? userId)
        {
            ViewBag.UserId = userId;

            //var db = new AppDbContext();
            //var lb5Db = new UserPetRepository();

            var petViewModels = new List<PetViewModel>();

            //var pets = db.Pets.Where(pet => pet.UserId == userId).ToList();//<---ADEN: used your line here, could use confirmation i know what this is doing!
            var pets = lb5Db.GetPets(userId);

            foreach (var pet in pets)
            {
                var petViewModel = MapToPetViewModel(pet);
                petViewModels.Add(petViewModel);
            }

            return View(petViewModels);
        }

        //MAP TO PET
        private Pet MapToPet(PetViewModel petViewModel)
        {
            return new Pet
            {
                Id = petViewModel.Id,
                Name = petViewModel.Name,
                Age = petViewModel.Age,
                UserId = petViewModel.UserId
            };
        }

        //MAP PET VIEW MODEL
        private PetViewModel MapToPetViewModel(Pet pet)
        {
            return new PetViewModel
            {
                Id = pet.Id,
                Name = pet.Name,
                Age = pet.Age,
                UserId = pet.UserId
            };
        }

        //EXTRA CREDIT_____________________________________________________________________________
        //DETAILS
        public ActionResult Details(int id)
        {
            //var db = new AppDbContext();

            var petViewModel = new PetViewModel();

            //var pet = db.Pets.Find(id);
            var pet = lb5Db.GetPet(id);

            petViewModel = MapToPetViewModel(pet);

            return View(petViewModel);
        }

        //DELETE
        public ActionResult Delete(int id)
        {
            //var db = new AppDbContext();

            //var pet = db.Pets.Find(id);
            var pet = lb5Db.GetPet(id);

            //if (pet != null)
            //{
            //    db.Pets.Remove(pet);

            //    db.SaveChanges();//<---VERY IMPORTANT: Updates DB
            //}
            lb5Db.DeletePet(id);

            return RedirectToAction("List", new { UserId = pet.UserId });
        }

        //EDIT: GET
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //var db = new AppDbContext();

            var petViewModel = new PetViewModel();

            //var pet = db.Pets.Find(id);
            var pet = lb5Db.GetPet(id);

            petViewModel = MapToPetViewModel(pet);

            return View(petViewModel);
        }

        //EDIT: POST
        [HttpPost]
        public ActionResult Edit(PetViewModel petViewModel)
        {
            //var db = new AppDbContext();

            if (ModelState.IsValid)
            {
                //var pet = db.Pets.Find(petViewModel.Id);
                var pet = lb5Db.GetPet(petViewModel.Id);

                pet.Id = petViewModel.Id;
                pet.Name = petViewModel.Name;
                pet.Age = petViewModel.Age;
                pet.UserId = petViewModel.UserId;

                //db.SaveChanges();//<---VERY IMPORTANT: Updates DB
                lb5Db.EditPet(pet);

                return RedirectToAction("List", new { UserId = pet.UserId });
            }

            return View();
        }
    }
}