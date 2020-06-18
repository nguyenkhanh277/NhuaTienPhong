using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class ProgramFunctionAuthority : Base
    {
        #region Fields
        public string Id { get; set; }
        public string ProgramName { get; set; }
        public string FunctionName { get; set; }
        public string AuthorityGroupID { get; set; }
        #endregion
    }
}
