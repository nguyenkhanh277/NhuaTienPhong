using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class OrderDetail : Base
    {
        #region Fields
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string WarehouseId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public string DiscountMoney { get; set; }
        public string Note { get; set; }
        #endregion
    }
}
