using System.Data.Entity;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Repositories;
using NhuaTienPhong.Persistence.Repositories;

namespace NhuaTienPhong.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProjectDataContext _projectDataContext;

        public UnitOfWork(ProjectDataContext projectDataContext)
        {
            this._projectDataContext = projectDataContext;
        }

        public int Complete()
        {
            return _projectDataContext.SaveChanges();
        }

        public void Dispose()
        {
            _projectDataContext.Dispose();
        }
    }
}