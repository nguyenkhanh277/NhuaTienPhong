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

namespace NhuaTienPhong.View.Products
{
    public partial class frmProductAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        ProductRepository _productRepository;
        CategoryRepository _categoryRepository;
        UnitRepository _unitRepository;

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

        public frmProductAddEdit()
        {
            InitializeComponent();
        }

        public frmProductAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmProductAddEdit_Load(object sender, EventArgs e)
        {
            _productRepository = new ProductRepository(_projectDataContext);
            _categoryRepository = new CategoryRepository(_projectDataContext);
            _unitRepository = new UnitRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LoadCategoryData();
            LoadUnitData();
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
            //Get Data Table Product
            Product product = _productRepository.Get(_id);
            cbbCategory.SelectedValue = product.CategoryId;
            txtItemCode.Text = product.ItemCode;
            txtItemName.Text = product.ItemName;
            cbbUnit.SelectedValue = product.UnitId;
            txtImportPrice.Value = (decimal)product.ImportPrice;
            txtSalePrice.Value = (decimal)product.SalePrice;
            txtRetailPrice.Value = (decimal)product.RetailPrice;
            txtGhiChu.Text = product.Note;
            chkUsing.Checked = (product.Status == GlobalConstants.StatusValue.Using);
        }

        private void LoadCategoryData()
        {
            cbbCategory.DataSource = _categoryRepository.GetAll().OrderBy(_ => _.CategoryName).ToList();
            cbbCategory.SelectedIndex = 0;
        }

        private void LoadUnitData()
        {
            cbbUnit.DataSource = _unitRepository.GetAll().OrderBy(_ => _.UnitName).ToList();
            cbbUnit.SelectedIndex = 0;
        }

        private bool CheckData()
        {
            if (cbbCategory.SelectedValue == null || cbbCategory.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbCategory.Focus();
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
            Product product = _productRepository.FirstOrDefault(_ => _.ItemCode.Equals(txtItemCode.Text.Trim()));
            if (product != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtItemCode.Text.Trim() != product.ItemCode)
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
                //Table Product
                Product product = new Product();
                product.Id = _id;
                product.CategoryId = cbbCategory.SelectedValue.ToString();
                product.ItemCode = txtItemCode.Text.Trim();
                product.ItemName = txtItemName.Text.Trim();
                product.UnitId = cbbUnit.SelectedValue.ToString();
                product.ImportPrice = (float)txtImportPrice.Value;
                product.SalePrice = (float)txtSalePrice.Value;
                product.RetailPrice = (float)txtRetailPrice.Value;
                product.Note = txtGhiChu.Text.Trim();
                product.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _productRepository.Save(product);
                UnitOfWork productOfWork = new UnitOfWork(_projectDataContext);
                int result = productOfWork.Complete();
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Categorys.frmCategoryAddEdit frm = new Categorys.frmCategoryAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                LoadCategoryData();
                cbbCategory.SelectedValue = (string)frm.Tag;
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            Units.frmUnitAddEdit frm = new Units.frmUnitAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                LoadUnitData();
                cbbUnit.SelectedValue = (string)frm.Tag;
            }
        }
    }
}