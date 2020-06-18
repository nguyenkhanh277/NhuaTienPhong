using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Inventory : Base
    {
        #region Fields
        public string Id { get; set; }
        public string WarehouseId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string UnitId { get; set; }
        public string SKU { get; set; }
        public float RemainActual { get; set; }
        public float RemainVirtual { get; set; }
        public float ImportPrice { get; set; }
        public float SalePrice { get; set; }
        public float RetailPrice { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
