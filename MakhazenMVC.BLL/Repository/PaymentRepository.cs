using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;

namespace MakhazenMVC.BLL.Repository
{
	public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}

