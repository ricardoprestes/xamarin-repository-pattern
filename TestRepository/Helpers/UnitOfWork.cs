using SQLite;
using TestRepository.Repository;
using TestRepository.Repository.Interfaces;

namespace TestRepository.Helpers
{
    public class UnitOfWork : IUnitOfWork
    {
        private SQLiteConnection _conn;
        private IUserRepository _userRepository;

        public UnitOfWork(SQLiteConnection conn)
        {
            _conn = conn;
        }

        public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(_conn));

        public void Dispose()
        {
            if (_conn != null)
                _conn.Dispose();
        }

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}
