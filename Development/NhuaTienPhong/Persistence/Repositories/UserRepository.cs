using NhuaTienPhong.Core.Domain;
using System.Collections.Generic;
using System.Linq;
using System;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.Persistence.Repositories
{
    public class UserRepository : Repository<User>
    {
        public string id = "";

        public UserRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(User user)
        {
            if (String.IsNullOrEmpty(user.Id))
            {
                user.Id = GetAutoID();
                user.Salt = SecurityHelper.CreateSalt(GlobalConstants.defaultSaltLength);
                user.Password = SecurityHelper.GenerateMD5(user.Password, user.Salt);
                user.CreatedAt = DateTime.Now;
                user.CreatedBy = GlobalConstants.username;
                Add(user);
                id = user.Id;
            }
            else
            {
                Update(user);
            }
        }

        public void Update(User user)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(user.Id));
                if (raw != null)
                {
                    if (!String.IsNullOrEmpty(user.Password))
                    {
                        user.Password = SecurityHelper.GenerateMD5(user.Password, raw.Salt);
                    }
                    else
                    {
                        user.Password = raw.Password;
                    }
                    raw.CollectInformation(user);
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

        public void ChangePassword(string username, string newPassword)
        {
            error = false;
            errorMessage = "";
            try
            {
                var user = FirstOrDefault(_ => _.Username.Equals(username));
                if (user != null)
                {
                    user.Password = SecurityHelper.GenerateMD5(newPassword, user.Salt);
                    user.EditedAt = DateTime.Now;
                    user.EditedBy = GlobalConstants.username;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public void CheckSecurity(string username, string password)
        {
            error = false;
            errorMessage = "";
            var user = FirstOrDefault(_ => _.Username.Equals(username));
            if (user != null)
            {
                String encryptedPassword = SecurityHelper.GenerateMD5(password, user.Salt);
                if (user.Password != encryptedPassword)
                {
                    error = true;
                    errorMessage = "Mật khẩu không đúng";
                }
                GlobalConstants.userID = user.Id;
                GlobalConstants.username = user.Username;
                GlobalConstants.fullName = user.FullName;
            }
            else
            {
                error = true;
                errorMessage = "Tài khoản không tồn tại";
            }
        }

        public bool CheckOperator(string username, string authorityGroupName)
        {
            bool result = false;
            var query = from x in ProjectDataContext.Users
                        join y in ProjectDataContext.UserAuthoritys on x.Id equals y.UserID
                        join z in ProjectDataContext.AuthorityGroups on y.AuthorityGroupID equals z.Id
                        where x.Username.Equals(username) && z.AuthorityGroupName.Equals(authorityGroupName)
                        select new { x, y, z };
            if (query.Any())
            {
                result = true;
            }
            return result;
        }

        public bool CheckPermission(string username, string program, string function)
        {
            bool result = false;
            errorMessage = "Bạn không có quyền sử dụng chức năng này";
            var query = from x in ProjectDataContext.Users
                        join y in ProjectDataContext.UserAuthoritys on x.Id equals y.UserID
                        join z in ProjectDataContext.ProgramFunctionAuthoritys on y.AuthorityGroupID equals z.AuthorityGroupID
                        where x.Username.Equals(username) && z.ProgramName.Equals(program) && z.FunctionName.Equals(function)
                        select new { x, y, z };
            if (query.Any())
            {
                result = true;
            }
            return result;
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}