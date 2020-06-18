using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class ProgramFunctionAuthorityRepository : Repository<ProgramFunctionAuthority>
    {
        public string id = "";

        public ProgramFunctionAuthorityRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(ProgramFunctionAuthority programFunctionAuthority)
        {
            if (String.IsNullOrEmpty(programFunctionAuthority.Id))
            {
                programFunctionAuthority.Id = GetAutoID();
                programFunctionAuthority.CreatedAt = DateTime.Now;
                programFunctionAuthority.CreatedBy = GlobalConstants.username;
                Add(programFunctionAuthority);
                id = programFunctionAuthority.Id;
            }
            else
            {
                Update(programFunctionAuthority);
            }
        }

        public void Update(ProgramFunctionAuthority programFunctionAuthority)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(programFunctionAuthority.Id));
                if (raw != null)
                {
                    raw.CollectInformation(programFunctionAuthority);
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

        public void DeleteByProgramAndFunction(string programName, string functionName)
        {
            error = false;
            errorMessage = "";
            try
            {
                var ProgramFunctionAuthority = ProjectDataContext.ProgramFunctionAuthoritys.Where(_ => _.ProgramName.Equals(programName) && _.FunctionName.Equals(functionName)).ToList();
                RemoveRange(ProgramFunctionAuthority);
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