using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;

namespace MakhazenMVC.BLL.Repository
{
	public class ConsumerRepository : GenericRepository<Consumer>, IConsumerRepository
    {
        public ConsumerRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

