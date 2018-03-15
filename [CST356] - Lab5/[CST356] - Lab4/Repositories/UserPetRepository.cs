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
        private readonly AppDbContext lb5_dbContext;

        public UserPetRepository(AppDbContext dbContext)
        {
            lb5_dbContext = dbContext;//<---step 3.1
        }        
    }
}