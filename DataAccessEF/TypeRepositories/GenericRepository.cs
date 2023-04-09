using DataAccessEF.MyDBContext;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.TypeRepositories
{

    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Fields
        protected readonly CustomContext _context;
        #endregion

        #region Constructor
        public GenericRepository(CustomContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods

        public async Task<T> GetById(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        #endregion
    }
}
