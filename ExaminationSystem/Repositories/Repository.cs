using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExaminationSystem.Repositories
{
    public class Repository <T>: IRepository<T> where T : BaseModel
    {
        Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            entity.isDeleted = true;
            Update(entity);
        }

        public void Delete(int id)
        {
            T entity = _context.Find<T>(id);
            Delete(entity);
        }

        public void HardDelete(int id)
        {

            _context.Set<T>().Where(x => x.ID == id).ExecuteDelete();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().Where(x => !x.isDeleted).AsNoTracking();
        }

        public T GetByID(int id)
        {
            return GetAll().FirstOrDefault(x => x.ID == id);
        }

        public T GetWithTrackinByID(int id)
        {
            return _context.Set<T>()
                .Where(x => !x.isDeleted && x.ID == id)
                .AsTracking()
                .FirstOrDefault();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return Get(predicate).FirstOrDefault();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
