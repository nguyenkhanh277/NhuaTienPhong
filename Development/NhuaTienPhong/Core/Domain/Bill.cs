using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Bill : Base
    {
        #region Fields
        public string Id { get; set; }
        public string SEQ { get; set; }
        public DateTime BillDate { get; set; }
        public string CustomerId { get; set; }
        public string CustomerCard { get; set; }
        public float Total { get; set; }
        public float VAT { get; set; }
        public float VATMoney { get; set; }//+
        public float Discout { get; set; }
        public float DiscoutMoney { get; set; }//-
        public float Deposits { get; set; }//-
        public float PaymentByCard { get; set; }//-
        public float PaymentByPoints { get; set; }//-
        public float PaymentInCash { get; set; }//-
        public float ExtraMoney { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
