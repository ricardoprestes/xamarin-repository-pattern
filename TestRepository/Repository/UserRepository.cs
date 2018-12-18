using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using TestRepository.Model;
using TestRepository.Repository.Interfaces;

namespace TestRepository.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(SQLiteConnection conn) : base(conn)
        {
        }

        public User Get(string identifier) => Connection.Get<User>(identifier);

        public List<User> Get() => Connection.Table<User>().Where(u => !u.Removed).ToList();

        public bool Insert(User user)
        {
            try
            {
                Connection.InsertOrReplace(user);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
