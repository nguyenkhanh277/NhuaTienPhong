using NhuaTienPhong.Core.Repositories;
using System;
using NhuaTienPhong.Persistence;

namespace NhuaTienPhong.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}