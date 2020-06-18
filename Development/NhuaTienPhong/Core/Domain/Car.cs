using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Car : Base
    {
        #region Fields
        public string Id { get; set; }
        public string CarNumber { get; set; }
        public string Driver { get; set; }
        public float Weight { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}