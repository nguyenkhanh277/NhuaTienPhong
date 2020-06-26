using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;
using System.Threading;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        readonly List<Product> listProducts = new List<Product>();
        readonly SynchronizationContext context;
        public string id = "";

        public ProductRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Product product)
        {
            if (String.IsNullOrEmpty(product.Id))
            {
                product.Id = GetAutoID();
                product.RemainActual = 0;
                product.RemainVirtual = 0;
                product.CreatedAt = DateTime.Now;
                product.CreatedBy = GlobalConstants.username;
                Add(product);
                id = product.Id;
            }
            else
            {
                Update(product);
            }
        }

        public void Update(Product product)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(product.Id));
                if (raw != null)
                {
                    raw.CollectInformation(product);
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

        public void CaculateRemainVirtual(string id, float quantity)
        {
            error = false;
            errorMessage = "";
            try
            {
                var product = FirstOrDefault(_ => _.Id.Equals(id));
                if (product != null)
                {
                    product.RemainVirtual = product.RemainVirtual - quantity;
                    product.EditedAt = DateTime.Now;
                    product.EditedBy = GlobalConstants.username;
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

        public List<Product> GetList()
        {
            var query = from x in ProjectDataContext.Products
                        join y in ProjectDataContext.Categorys on x.CategoryId equals y.Id
                        join z in ProjectDataContext.Units on x.UnitId equals z.Id
                        select new { x, y, z };

            List<Product> products = new List<Product>();
            Product product = new Product();
            if (query.Any())
            {
                foreach (var item in query)
                {
                    product = new Product();
                    product.Id = item.x.Id;
                    product.CategoryId = item.x.CategoryId;
                    product.CategoryName = item.y.CategoryName;
                    product.ItemCode = item.x.ItemCode;
                    product.ItemName = item.x.ItemName;
                    product.UnitId = item.x.UnitId;
                    product.UnitName = item.z.UnitName;
                    product.SKU = item.x.SKU;
                    product.RemainActual = item.x.RemainActual;
                    product.RemainVirtual = item.x.RemainVirtual;
                    product.ImportPrice = item.x.ImportPrice;
                    product.SalePrice = item.x.SalePrice;
                    product.RetailPrice = item.x.RetailPrice;
                    product.Note = item.x.Note;
                    product.Status = item.x.Status;
                    products.Add(product);
                }
            }
            return products;
        }
    }
}