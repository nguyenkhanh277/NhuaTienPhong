using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Order : Base
    {
        #region Fields
        public string Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string CarNumberOrder { get; set; }
        public GlobalConstants.UseCarStatusValue UseCarStatus { get; set; }
        public string Total { get; set; }
        public string VAT { get; set; }
        public string VATMoney { get; set; }
        public float SEQ { get; set; }
        public GlobalConstants.ProcessingCarStatusValue ProcessingCarStatus { get; set; }
        public string CarNumber { get; set; }
        public string Driver { get; set; }
        public DateTime ApprovalDate { get; set; }
        public GlobalConstants.ProcessingStatusValue ProcessingStatus { get; set; }
        public string OrderNoMerge { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion

        #region FK
        public Order()
        {
            orderDetails = new ObservableCollection<OrderDetail>();
        }

        public virtual ObservableCollection<OrderDetail> orderDetails { get; set; }
        #endregion
    }
}
