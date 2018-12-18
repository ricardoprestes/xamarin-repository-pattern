using System;
using System.Collections.Generic;
using System.Text;
using TestRepository.Repository.Interfaces;

namespace TestRepository.Helpers
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
    }
}
