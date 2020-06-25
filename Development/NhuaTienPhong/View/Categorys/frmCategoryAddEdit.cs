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

namespace NhuaTienPhong.View.Categorys
{
    public partial class frmCategoryAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        CategoryRepository _categoryRepository;

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
        bool _quickAdd = false;

        public frmCategoryAddEdit()
        {
            InitializeComponent();
        }

        public frmCategoryAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmCategoryAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmCategoryAddEdit_Load(object sender, EventArgs e)
        {
            _categoryRepository = new CategoryRepository(_projectDataContext);
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
            txtCategoryName.Text = "";
            txtGhiChu.Text = "";
            chkUsing.Checked = true;
            txtCategoryName.Focus();
        }

        private void GetData()
        {
            //Get Data Table Category
            Category category = _categoryRepository.Get(_id);
            txtCategoryName.Text = category.CategoryName;
            txtGhiChu.Text = category.Note;
            chkUsing.Checked = (category.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtCategoryName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return false;
            }
            Category category = _categoryRepository.FirstOrDefault(_ => _.CategoryName.Equals(txtCategoryName.Text.Trim()));
            if (category != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtCategoryName.Text.Trim() != category.CategoryName)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Category
                Category category = new Category();
                category.Id = _id;
                category.CategoryName = txtCategoryName.Text.Trim();
                category.Note = txtGhiChu.Text.Trim();
                category.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _categoryRepository.Save(category);
                UnitOfWork categoryOfWork = new UnitOfWork(_projectDataContext);
                int result = categoryOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = _categoryRepository.id;
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                            Clear();
                        }
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