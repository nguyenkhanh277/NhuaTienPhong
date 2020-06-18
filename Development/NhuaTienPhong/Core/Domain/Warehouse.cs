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

        #region FK
        public Warehouse()
        {
            inventorys = new ObservableCollection<Inventory>();
        }

        public virtual ObservableCollection<Inventory> inventorys { get; set; }
        #endregion
    }
}
