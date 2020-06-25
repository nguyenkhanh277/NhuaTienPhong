using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhuaTienPhong.Persistence;
using NhuaTienPhong.Persistence.Repositories;
using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.View.ProgramFunctionMasters
{
    public partial class frmProgramFunctionMasterAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        ProgramFunctionMasterRepository _programFunctionMasterRepository;

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

        public frmProgramFunctionMasterAddEdit()
        {
            InitializeComponent();
        }

        public frmProgramFunctionMasterAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmProgramFunctionMasterAddEdit_Load(object sender, EventArgs e)
        {
            _programFunctionMasterRepository = new ProgramFunctionMasterRepository(_projectDataContext);
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
            txtProgramName.Text = "";
            txtFunctionName.Text = "";
            txtExplanation.Text = "";
            chkUsing.Checked = true;
            txtProgramName.Focus();
        }

        private void GetData()
        {
            //Get Data Table ProgramFunctionMaster
            ProgramFunctionMaster programFunctionMaster = _programFunctionMasterRepository.Get(_id);
            txtProgramName.Text = programFunctionMaster.ProgramName;
            txtFunctionName.Text = programFunctionMaster.FunctionName;
            txtExplanation.Text = programFunctionMaster.Explanation;
            chkUsing.Checked = (programFunctionMaster.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtProgramName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProgramName.Focus();
                return false;
            }
            else if (txtFunctionName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFunctionName.Focus();
                return false;
            }
            ProgramFunctionMaster programFunctionMaster = _programFunctionMasterRepository.FirstOrDefault(_ => _.ProgramName.Equals(txtProgramName.Text.Trim()) && _.FunctionName.Equals(txtFunctionName.Text.Trim()));
            if (programFunctionMaster != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && (txtProgramName.Text.Trim() != programFunctionMaster.ProgramName || txtFunctionName.Text.Trim() != programFunctionMaster.FunctionName))
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFunctionName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table ProgramFunctionMaster
                ProgramFunctionMaster programFunctionMaster = new ProgramFunctionMaster();
                programFunctionMaster.Id = _id;
                programFunctionMaster.ProgramName = txtProgramName.Text.Trim();
                programFunctionMaster.FunctionName = txtFunctionName.Text.Trim();
                programFunctionMaster.Explanation = txtExplanation.Text.Trim();
                programFunctionMaster.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _programFunctionMasterRepository.Save(programFunctionMaster);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
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