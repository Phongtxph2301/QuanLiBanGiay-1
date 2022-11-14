namespace A_DAL.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T? GetById(object id);
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        void Save();
    }
}
