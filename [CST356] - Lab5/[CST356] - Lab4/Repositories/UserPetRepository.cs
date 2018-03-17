using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _CST356____Lab4.Data;//<---added
using _CST356____Lab4.Data.Entities;//<---added

namespace _CST356____Lab4.Repositories
{

    public class UserPetRepository : IUserPetRepository//<---step 2
    {
        //VARIABLES: MEMBERS
        private AppDbContext lb5DbContext;
        
        //CONSTRUCTOR
        public UserPetRepository()
        {
            lb5DbContext = new AppDbContext();//<---step 3.1
        }

        //USER METHODS_____________________________________________________________________________
        //GET: User By Id
        public User GetUser(int id)
        {
            return lb5DbContext.Users.Find(id);
        }

        //GET: All Users
        public IEnumerable<User> GetUsers()
        {
            return lb5DbContext.Users;
        }

        //ADDSAVE: User
        public void AddSaveUser(User user)
        {
            lb5DbContext.Users.Add(user);

            lb5DbContext.SaveChanges();
        }

        //EDIT: Update User
        public void EditUser(User user)
        {
            lb5DbContext.SaveChanges();
        }

        //DELETE: User By Id
        public void DeleteUser(int id)
        {
            var user = lb5DbContext.Users.Find(id);

            if (user == null)
                return;
            else
            {
                lb5DbContext.Users.Remove(user);

                lb5DbContext.SaveChanges();
            }
        }
        //PET METHODS______________________________________________________________________________
        //GET: Pet by Id
        public Pet GetPet(int id)
        {
            return lb5DbContext.Pets.Find(id);
        }

        //GET: All Pets By User Id
        public IEnumerable<Pet> GetPets(int? userId)
        {
            return lb5DbContext.Pets.Where(pet => pet.UserId == userId).ToList();
        }
        
        //ADDSAVE: Pet
        public void AddSavePet(Pet pet)
        {
            lb5DbContext.Pets.Add(pet);

            lb5DbContext.SaveChanges();
        }

        //EDIT: Update Pet
        public void EditPet(Pet pet)
        {
            lb5DbContext.SaveChanges();
        }

        //DELETE: Pet By Id
        public void DeletePet(int id)
        {
            var pet = lb5DbContext.Pets.Find(id);

            if (pet == null)
            {
                return;
            }
            else
            {
                lb5DbContext.Pets.Remove(pet);
                lb5DbContext.SaveChanges();
            }
        }
    }
}