using System;

namespace Service.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}