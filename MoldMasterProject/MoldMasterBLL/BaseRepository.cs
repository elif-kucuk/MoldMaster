using MoldMasterDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoldMasterBLL
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        MoldMasterEntities db = new MoldMasterEntities();
        public void Delete(int itemId)
        {
            var deleted = db.Set(typeof(T)).Find(itemId);
            db.Set((typeof(T))).Remove(deleted);
            db.SaveChanges();
        }

        //public T FindWorker(string itemName, string itemSurname, string itemPassword)
        //{
        //    var user = db.Set(typeof(T)).Cast<T>().Where(typeof(Employee).IsAssignableFrom(typeof(T)))
        //}

        public void Insert(T item)
        {
            db.Set(typeof(T)).Add(item);
            db.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T SelectedById(int itemId)
        {
            return db.Set(typeof(T)).Cast<T>().Find(itemId);
        }

        public void Update(T item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }


    }

}