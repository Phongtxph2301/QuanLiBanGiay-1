using A_DAL.Context;
using A_DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly NahidaShoesDbContext _context = new();
        private readonly DbSet<T> table;
        public GenericRepository()
        {
            table = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T? GetById(object id)
        {
            return table.Find(id);
        }
        public bool Add(T obj)
        {
            if (obj == null)
            {
                return false;
            }
            _ = table.Add(obj);
            Save();
            return true;
        }
        public bool Update(T obj)
        {
            if (obj == null)
            {
                return false;
            }
            _ = table.Update(obj);
            Save();
            return true;
        }
        public bool Delete(T obj)
        {
            if (obj == null)
            {
                return false;
            }
            _ = table.Remove(obj);
            Save();
            return true;
        }
        public void Save()
        {
            _ = _context.SaveChanges();
        }
    }
}
