using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;

namespace MakhazenMVC.BLL.Repository
{
	public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
		public BookingRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}

