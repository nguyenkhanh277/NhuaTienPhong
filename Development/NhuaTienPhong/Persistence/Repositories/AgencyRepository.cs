using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class AgencyRepository : Repository<Agency>
    {
        public string id = "";

        public AgencyRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Agency agency)
        {
            if (String.IsNullOrEmpty(agency.Id))
            {
                agency.Id = GetAutoID();
                agency.CreatedAt = DateTime.Now;
                agency.CreatedBy = GlobalConstants.username;
                Add(agency);
                id = agency.Id;
            }
            else
            {
                Update(agency);
            }
        }

        public void Update(Agency agency)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(agency.Id));
                if (raw != null)
                {
                    raw.CollectInformation(agency);
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