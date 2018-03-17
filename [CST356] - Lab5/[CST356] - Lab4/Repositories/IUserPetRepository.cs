using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _CST356____Lab4.Data.Entities;//<---added

namespace _CST356____Lab4.Repositories
{
    public interface IUserPetRepository//<---step 2
    {
        //USER METHODS
        User GetUser(int id);
        IEnumerable<User> GetUsers();
        void AddSaveUser(User user);
        void EditUser(User user);
        void DeleteUser(int id);

        //PET METHODS
        Pet GetPet(int id);
        IEnumerable<Pet> GetPets(int? userId);
        void AddSavePet(Pet pet);
        void EditPet(Pet user);
        void DeletePet(int id);
    }
}