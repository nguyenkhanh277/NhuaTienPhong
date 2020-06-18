using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhuaTienPhong.Persistence;
using NhuaTienPhong.Persistence.Repositories;
using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.View.Inventorys
{
    public partial class frmInventoryAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        InventoryRepository _inventoryRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.KeyCode == Keys.F1)
            {
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string _id = "";

        public frmInventoryAddEdit()
        {
            InitializeComponent();
        }

        public frmInventoryAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmInventoryAddEdit_Load(object sender, EventArgs e)
        {
            _inventoryRepository = new InventoryRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
        }

        private void Clear()
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtImportPrice.Value = 0;
            txtSalePrice.Value = 0;
            txtRetailPrice.Value = 0;
            txtGhiChu.Text = "";
            chkUsing.Checked = true;
            txtItemCode.Focus();
        }

        private void GetData()
        {
            //Get Data Table Inventory
            Inventory inventory = _inventoryRepository.Get(_id);
            cbbWarehouse.SelectedValue = inventory.WarehouseId;
            txtItemCode.Text = inventory.ItemCode;
            txtItemName.Text = inventory.ItemName;
            cbbUnit.SelectedValue = inventory.UnitId;
            txtImportPrice.Value = (decimal)inventory.ImportPrice;
            txtSalePrice.Value = (decimal)inventory.SalePrice;
            txtRetailPrice.Value = (decimal)inventory.RetailPrice;
            txtGhiChu.Text = inventory.Note;
            chkUsing.Checked = (inventory.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (cbbWarehouse.SelectedValue == null || cbbWarehouse.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbWarehouse.Focus();
                return false;
            }
            else if (txtItemCode.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
                return false;
            }
            else if (txtItemName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }
            else if (cbbUnit.SelectedValue == null || cbbUnit.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbUnit.Focus();
                return false;
            }
            Inventory inventory = _inventoryRepository.FirstOrDefault(_ => _.ItemCode.Equals(txtItemCode.Text.Trim()));
            if (inventory != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtItemCode.Text.Trim() != inventory.ItemCode)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemCode.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Inventory
                Inventory inventory = new Inventory();
                inventory.Id = _id;
                inventory.WarehouseId = cbbWarehouse.SelectedValue.ToString();
                inventory.ItemCode = txtItemCode.Text.Trim();
                inventory.ItemName = txtItemName.Text.Trim();
                inventory.UnitId = cbbUnit.SelectedValue.ToString();
                inventory.ImportPrice = (float)txtImportPrice.Value;
                inventory.SalePrice = (float)txtSalePrice.Value;
                inventory.RetailPrice = (float)txtRetailPrice.Value;
                inventory.Note = txtGhiChu.Text.Trim();
                inventory.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _inventoryRepository.Save(inventory);
                UnitOfWork inventoryOfWork = new UnitOfWork(_projectDataContext);
                int result = inventoryOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                        Clear();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}