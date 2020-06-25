using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public string id = "";

        public CategoryRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Category category)
        {
            if (String.IsNullOrEmpty(category.Id))
            {
                category.Id = GetAutoID();
                category.CreatedAt = DateTime.Now;
                category.CreatedBy = GlobalConstants.username;
                Add(category);
                id = category.Id;
            }
            else
            {
                Update(category);
            }
        }

        public void Update(Category category)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(category.Id));
                if (raw != null)
                {
                    raw.CollectInformation(category);
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