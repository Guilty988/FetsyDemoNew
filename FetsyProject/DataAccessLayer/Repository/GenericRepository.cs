using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var delete = new Context();
            delete.Remove(t);
            delete.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();

        }

        public void Insert(T t)
        {
            using var insert = new Context();
            insert.Add(t);
            insert.SaveChanges();
        }

        public void Update(T t)
        {
           using var update = new Context();
           update.Add(t);
           update.SaveChanges();
        }
    }
}
