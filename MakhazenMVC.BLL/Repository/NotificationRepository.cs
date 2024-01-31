using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;
using MakhazenMVC.DAL.Model;

namespace MakhazenMVC.BLL.Repository
{
    public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}