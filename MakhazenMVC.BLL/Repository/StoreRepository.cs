using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;

namespace MakhazenMVC.BLL.Repository
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

