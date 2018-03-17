using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;//<---added
using System.Web;
//using System.Web.Mvc;//<---causes ambiguous reference with attributes
using _CST356____Lab4.Data;//<---added
using _CST356____Lab4.Data.Entities;//<---added

namespace MyAppApi.Controllers
{
    public class PetController : ApiController
    {
        //instantiate AppDbContext
        private AppDbContext db_lb9;

        //constructor
        public PetController()
        {
            db_lb9 = new AppDbContext();
        }

        //GET: All
        [HttpGet]
        public IEnumerable<Pet> GetAllPets()
        {
            return db_lb9.Pets.ToList();
        }

        //GET: By Id
        [HttpGet]
        public IHttpActionResult GetPet(int id)
        {
            var pet = db_lb9.Pets.FirstOrDefault((p) => p.Id == id);

            if(pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }
    }
}