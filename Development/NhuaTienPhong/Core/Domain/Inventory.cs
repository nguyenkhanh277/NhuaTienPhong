using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhuaTienPhong.Core.Domain
{
    public class Inventory : Base
    {
        #region Fields
        [Key, Column(Order = 0)]
        public string WarehouseId { get; set; }
        [Key, Column(Order = 1)]
        public string ProductId { get; set; }
        public float RemainVirtual { get; set; }
        public float RemainActual { get; set; }
        [NotMapped]
        public string WarehouseName { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }
        [NotMapped]
        public string ItemCode { get; set; }
        [NotMapped]
        public string ItemName { get; set; }
        [NotMapped]
        public string UnitName { get; set; }
        [NotMapped]
        public string SKU { get; set; }
        [NotMapped]
        public float ImportPrice { get; set; }
        [NotMapped]
        public float SalePrice { get; set; }
        [NotMapped]
        public float RetailPrice { get; set; }
        #endregion
    }
}
