using System;
namespace MakhazenMVC.BLL.interfaces
{

    public interface IUnitofWork
		{
		public IBookingRepository BookingRepository { get; set; }

        public IConsumerRepository consumerRepository { get; set; }

		public INotificationRepository NotificationRepository { get; set; }

		public IPaymentRepository paymentRepository { get; set; }

		public IProviderRepository providerRepository { get; set; }

		public IReviewRepository ReviewRepository { get; set; }

		public IStoreRepository StoreRepository { get; set; }

		public IUserReposoitory UserReposoitory { get; set; }
	}
}


