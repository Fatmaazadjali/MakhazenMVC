using System;
using MakhazenMVC.BLL.interfaces;
using MakhazenMVC.DAL.Context;

namespace MakhazenMVC.BLL.Repository
{
    public class UnitofWork : IUnitofWork
    {
        public IBookingRepository BookingRepository { get; set; }
        public IConsumerRepository consumerRepository { get; set; }
        public INotificationRepository NotificationRepository { get; set; }
        public IPaymentRepository paymentRepository { get ; set ; }
        public IProviderRepository providerRepository { get; set; }
        public IReviewRepository ReviewRepository { get; set; }
        public IStoreRepository StoreRepository { get; set; }
        public IUserReposoitory UserReposoitory { get; set; }

        public UnitofWork(ApplicationDbContext context)
        {

            BookingRepository = new BookingRepository(context);
            consumerRepository = new ConsumerRepository(context);
            NotificationRepository = new NotificationRepository(context);
            paymentRepository = new PaymentRepository(context);
            providerRepository = new ProviderRepository(context);
            ReviewRepository = new ReviewRepository(context);
            StoreRepository = new StoreRepository(context);
            UserReposoitory = new UserRepository(context);

        }
    }
}

