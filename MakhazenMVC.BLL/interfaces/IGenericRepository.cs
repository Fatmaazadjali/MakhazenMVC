using System;
namespace MakhazenMVC.BLL.interfaces
{
	
		public interface IGenericRepository<T>
		{
            IEnumerable<T> GetAll();
            T Get(int id);
            int Create(T item);
            int Update(T item);
            int Delete(T item);
    }
}


