using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class UserAuthority : Base
    {
        #region Fields
        public string Id { get; set; }
        public string UserID { get; set; }
        public string AuthorityGroupID { get; set; }
        #endregion
    }
}
