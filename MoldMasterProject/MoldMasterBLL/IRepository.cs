using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoldMasterBLL
{
    public interface IRepository<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
        //T FindWorker(string itemName, string itemSurname, string itemPassword);
        List<T> SelectAll();
        T SelectedById(int itemId);
    }
}
