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
        public float Quantity { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float DiscountMoney { get; set; }
        public string Note { get; set; }
        #endregion
    }
}
