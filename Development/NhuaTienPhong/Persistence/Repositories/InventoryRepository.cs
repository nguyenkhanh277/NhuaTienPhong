using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class InventoryRepository : Repository<Inventory>
    {
        public string id = "";

        public InventoryRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Inventory inventory)
        {
            if (String.IsNullOrEmpty(inventory.Id))
            {
                inventory.Id = GetAutoID();
                inventory.RemainActual = 0;
                inventory.RemainVirtual = 0;
                inventory.CreatedAt = DateTime.Now;
                inventory.CreatedBy = GlobalConstants.username;
                Add(inventory);
                id = inventory.Id;
            }
            else
            {
                Update(inventory);
            }
        }

        public void Update(Inventory inventory)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(inventory.Id));
                if (raw != null)
                {
                    raw.CollectInformation(inventory);
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