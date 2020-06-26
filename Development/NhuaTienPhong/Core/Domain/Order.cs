using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Order : Base
    {
        #region Fields
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CarNumberOrder { get; set; }
        public GlobalConstants.UseCarStatusValue UseCarStatus { get; set; }
        public float Total { get; set; }
        public float VAT { get; set; }
        public float VATMoney { get; set; }
        public string SEQ { get; set; }
        public GlobalConstants.ProcessingCarStatusValue ProcessingCarStatus { get; set; }
        public string CarNumber { get; set; }
        public string Driver { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public GlobalConstants.ProcessingStatusValue ProcessingStatus { get; set; }
        public string OrderNoMerge { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
