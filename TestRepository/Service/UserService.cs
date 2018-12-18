using SQLite;
using System.Collections.Generic;
using TestRepository.Helpers;
using TestRepository.Model;
using TestRepository.Service.Interfaces;

namespace TestRepository.Service
{
    public class UserService : BaseService, IUserService
    {
        public UserService(SQLiteConnection conn) : base(conn)
        {
        }

        public User Get(string identifier) => new UnitOfWork(Connection).UserRepository.Get(identifier);

        public List<User> Get() => new UnitOfWork(Connection).UserRepository.Get();

        public bool Insert(User user)
        {
            var uow = new UnitOfWork(Connection);
            var result = uow.UserRepository.Insert(user);
            return result;
        }
    }
}
