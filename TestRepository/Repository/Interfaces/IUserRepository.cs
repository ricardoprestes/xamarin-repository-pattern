using System.Collections.Generic;
using TestRepository.Model;

namespace TestRepository.Repository.Interfaces
{
    public interface IUserRepository
    {
        User Get(string identifier);
        List<User> Get();
        bool Insert(User user);
    }
}
