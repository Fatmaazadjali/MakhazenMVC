using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;

namespace MakhazenMVC.BLL.Repository
{
	public class UserRepository : GenericRepository<User>, IUserReposoitory
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

