using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class AuthorityGroup : Base
    {
        #region Fields
        public string Id { get; set; }
        public string AuthorityGroupName { get; set; }
        public int? Sort { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion

        #region FK
        public AuthorityGroup()
        {
            userAuthoritys = new ObservableCollection<UserAuthority>();
            programFunctionAuthoritys = new ObservableCollection<ProgramFunctionAuthority>();
        }

        public virtual ObservableCollection<UserAuthority> userAuthoritys { get; set; }
        public virtual ObservableCollection<ProgramFunctionAuthority> programFunctionAuthoritys { get; set; }
        #endregion
    }
}
