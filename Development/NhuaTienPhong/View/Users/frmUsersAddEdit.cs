﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhuaTienPhong.Persistence;
using NhuaTienPhong.Persistence.Repositories;
using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.View.Users
{
    public partial class frmUsersAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;
        AuthorityGroupRepository _authorityGroupRepository;
        UserAuthorityRepository _userAuthorityRepository;

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

        public frmUsersAddEdit()
        {
            InitializeComponent();
        }

        public frmUsersAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmUsersAddEdit_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository(_projectDataContext);
            _authorityGroupRepository = new AuthorityGroupRepository(_projectDataContext);
            _userAuthorityRepository = new UserAuthorityRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageDataGridView(dgvDuLieu);
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
            LoadAuthority();
        }

        private void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword.Enabled = true;
            txtFullName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            chkMale.Checked = true;
            txtNote.Text = "";
            chkUsing.Checked = true;
            txtUsername.Focus();
        }

        private void GetData()
        {
            //Get Data Table User
            User user = _userRepository.Get(_id);
            txtUsername.Text = user.Username;
            txtPassword.Text = "";
            txtPassword.Enabled = false;
            txtFullName.Text = user.FullName;
            txtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;
            chkMale.Checked = (user.Gender == GlobalConstants.GenderValue.Male);
            txtNote.Text = user.Note;
            chkUsing.Checked = (user.Status == GlobalConstants.StatusValue.Using);
        }

        private void LoadAuthority()
        {
            var authorityGroups = _authorityGroupRepository.Find(_ => _.Status == GlobalConstants.StatusValue.Using).OrderBy(_ => _.Sort);
            var userAuthoritys = _userAuthorityRepository.Find(_ => _.UserID.Equals(_id));

            dgvDuLieu.Rows.Clear();
            int check = 0;
            foreach (var authorityGroup in authorityGroups)
            {
                check = 0;
                foreach (var programFunctionAuthority in userAuthoritys)
                {
                    if (programFunctionAuthority.AuthorityGroupID == authorityGroup.Id)
                    {
                        check = 1;
                        break;
                    }
                }
                object[] rowAdd = { check, authorityGroup.Id, authorityGroup.AuthorityGroupName };
                dgvDuLieu.Rows.Add(rowAdd);
            }
        }

        private bool CheckData()
        {
            if (txtUsername.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            else if (txtFullName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }
            User user = _userRepository.FirstOrDefault(_ => _.Username.Equals(txtUsername.Text.Trim()));
            if(user != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtUsername.Text.Trim() != user.Username)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table User
                User user = new User();
                user.Id = _id;
                user.Username = txtUsername.Text.Trim();
                user.Password = txtPassword.Text.Trim();
                user.FullName = txtFullName.Text.Trim();
                user.Phone = txtPhone.Text.Trim();
                user.Address = txtAddress.Text.Trim();
                user.Gender = (chkMale.Checked ? GlobalConstants.GenderValue.Male : GlobalConstants.GenderValue.Female);
                user.Note = txtNote.Text.Trim();
                user.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _userRepository.Save(user);
                if (!String.IsNullOrEmpty(_userRepository.id))
                {
                    _userAuthorityRepository.DeleteByUserID(_userRepository.id);
                    for (int i = 0; i < dgvDuLieu.RowCount; i++)
                    {
                        if (dgvDuLieu.Rows[i].Cells["Assign"].Value.ToString() == "1")
                        {
                            UserAuthority userAuthority = new UserAuthority();
                            userAuthority.AuthorityGroupID = dgvDuLieu.Rows[i].Cells["Id"].Value.ToString();
                            userAuthority.UserID = _userRepository.id;
                            _userAuthorityRepository.Save(userAuthority);
                        }
                    }
                }
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