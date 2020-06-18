using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class UnitRepository : Repository<Unit>
    {
        public string id = "";

        public UnitRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Unit unit)
        {
            if (String.IsNullOrEmpty(unit.Id))
            {
                unit.Id = GetAutoID();
                unit.CreatedAt = DateTime.Now;
                unit.CreatedBy = GlobalConstants.username;
                Add(unit);
                id = unit.Id;
            }
            else
            {
                Update(unit);
            }
        }

        public void Update(Unit unit)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(unit.Id));
                if (raw != null)
                {
                    raw.CollectInformation(unit);
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