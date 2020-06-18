using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class AuthorityGroupRepository : Repository<AuthorityGroup>
    {
        public string id = "";

        public AuthorityGroupRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(AuthorityGroup authorityGroup)
        {
            if (String.IsNullOrEmpty(authorityGroup.Id))
            {
                authorityGroup.Id = GetAutoID();
                authorityGroup.CreatedAt = DateTime.Now;
                authorityGroup.CreatedBy = GlobalConstants.username;
                Add(authorityGroup);
                id = authorityGroup.Id;
            }
            else
            {
                Update(authorityGroup);
            }
        }

        public void Update(AuthorityGroup authorityGroup)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(authorityGroup.Id));
                if (raw != null)
                {
                    raw.CollectInformation(authorityGroup);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    this.id = raw.Id;
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