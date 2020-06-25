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

        public List<Inventory> GetList()
        {
            var query = from x in ProjectDataContext.Inventorys
                        join y in ProjectDataContext.Warehouses on x.WarehouseId equals y.Id
                        join z in ProjectDataContext.Products on x.ProductId equals z.Id
                        join a in ProjectDataContext.Categorys on z.CategoryId equals a.Id
                        join b in ProjectDataContext.Units on z.UnitId equals b.Id
                        select new { x, y, z, a, b };

            List<Inventory> inventorys = new List<Inventory>();
            Inventory inventory = new Inventory();
            if (query.Any())
            {
                foreach (var item in query)
                {
                    inventory = new Inventory();
                    inventory.WarehouseId = item.x.WarehouseId;
                    inventory.ProductId = item.x.ProductId;
                    inventory.RemainActual = item.x.RemainActual;
                    inventory.RemainVirtual = item.x.RemainVirtual;
                    inventory.WarehouseName = item.y.WarehouseName;
                    inventory.CategoryName = item.a.CategoryName;
                    inventory.ItemCode = item.z.ItemCode;
                    inventory.ItemName = item.z.ItemName;
                    inventory.UnitName = item.b.UnitName;
                    inventory.SKU = item.z.SKU;
                    inventory.ImportPrice = item.z.ImportPrice;
                    inventory.SalePrice = item.z.SalePrice;
                    inventory.RetailPrice = item.z.RetailPrice;
                    inventorys.Add(inventory);
                }
            }
            return inventorys;
        }
    }
}