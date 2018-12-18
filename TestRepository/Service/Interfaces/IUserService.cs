using System.Collections.Generic;
using TestRepository.Model;

namespace TestRepository.Service.Interfaces
{
    public interface IUserService
    {
        User Get(string identifier);
        List<User> Get();
        bool Insert(User user);
    }
}
