using System;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Core.Domain
{
    public class Category : Base
    {
        #region Fields
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion

        #region FK
        public Category()
        {
            inventorys = new ObservableCollection<Inventory>();
        }

        public virtual ObservableCollection<Inventory> inventorys { get; set; }
        #endregion
    }
}
