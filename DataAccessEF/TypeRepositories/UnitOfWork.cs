using DataAccessEF.MyDBContext;
using Domain.Interfaces;

namespace DataAccessEF.TypeRepositories
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly CustomContext _context;
        public IUserRepository User { get; }
        #endregion

        #region Constructor
        public UnitOfWork(CustomContext context, IUserRepository userRepository)
        {
            _context = context;
            User = userRepository;
        }
        #endregion

        #region Methods
        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        #endregion
    }
}
