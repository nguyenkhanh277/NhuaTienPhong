using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Warehouse : Base
    {
        #region Fields
        public string Id { get; set; }
        public string WarehouseName { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
