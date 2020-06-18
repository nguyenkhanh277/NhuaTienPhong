using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class WarehouseRepository : Repository<Warehouse>
    {
        public string id = "";

        public WarehouseRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Warehouse warehouse)
        {
            if (String.IsNullOrEmpty(warehouse.Id))
            {
                warehouse.Id = GetAutoID();
                warehouse.CreatedAt = DateTime.Now;
                warehouse.CreatedBy = GlobalConstants.username;
                Add(warehouse);
                id = warehouse.Id;
            }
            else
            {
                Update(warehouse);
            }
        }

        public void Update(Warehouse warehouse)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(warehouse.Id));
                if (raw != null)
                {
                    raw.CollectInformation(warehouse);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}