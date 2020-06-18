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

namespace NhuaTienPhong.View.Warehouses
{
    public partial class frmWarehouseAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        WarehouseRepository _warehouseRepository;

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

        public frmWarehouseAddEdit()
        {
            InitializeComponent();
        }

        public frmWarehouseAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmWarehouseAddEdit_Load(object sender, EventArgs e)
        {
            _warehouseRepository = new WarehouseRepository(_projectDataContext);
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
            txtWarehouseName.Text = "";
            txtGhiChu.Text = "";
            chkUsing.Checked = true;
            txtWarehouseName.Focus();
        }

        private void GetData()
        {
            //Get Data Table Warehouse
            Warehouse warehouse = _warehouseRepository.Get(_id);
            txtWarehouseName.Text = warehouse.WarehouseName;
            txtGhiChu.Text = warehouse.Note;
            chkUsing.Checked = (warehouse.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtWarehouseName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWarehouseName.Focus();
                return false;
            }
            Warehouse warehouse = _warehouseRepository.FirstOrDefault(_ => _.WarehouseName.Equals(txtWarehouseName.Text.Trim()));
            if (warehouse != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtWarehouseName.Text.Trim() != warehouse.WarehouseName)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWarehouseName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Warehouse
                Warehouse warehouse = new Warehouse();
                warehouse.Id = _id;
                warehouse.WarehouseName = txtWarehouseName.Text.Trim();
                warehouse.Note = txtGhiChu.Text.Trim();
                warehouse.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _warehouseRepository.Save(warehouse);
                UnitOfWork warehouseOfWork = new UnitOfWork(_projectDataContext);
                int result = warehouseOfWork.Complete();
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