using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhuaTienPhong.Persistence;
using NhuaTienPhong.Persistence.Repositories;
using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;

namespace NhuaTienPhong.View.Cars
{
    public partial class frmCarAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        CarRepository _carRepository;

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

        public frmCarAddEdit()
        {
            InitializeComponent();
        }

        public frmCarAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmCarAddEdit_Load(object sender, EventArgs e)
        {
            _carRepository = new CarRepository(_projectDataContext);
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
            txtCarNumber.Text = "";
            txtDriver.Text = "";
            txtWeight.Value = 0;
            txtGhiChu.Text = "";
            chkUsing.Checked = true;
            txtCarNumber.Focus();
        }

        private void GetData()
        {
            //Get Data Table Car
            Car car = _carRepository.Get(_id);
            txtCarNumber.Text = car.CarNumber;
            txtDriver.Text = car.Driver;
            txtWeight.Value = (decimal)car.Weight;
            txtGhiChu.Text = car.Note;
            chkUsing.Checked = (car.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            if (txtCarNumber.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarNumber.Focus();
                return false;
            }
            Car car = _carRepository.FirstOrDefault(_ => _.CarNumber.Equals(txtCarNumber.Text.Trim()));
            if (car != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtCarNumber.Text.Trim() != car.CarNumber)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarNumber.Focus();
                return false;
            }
            else if (txtWeight.Value == 0)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Car
                Car car = new Car();
                car.Id = _id;
                car.CarNumber = txtCarNumber.Text.Trim();
                car.Driver = txtDriver.Text.Trim();
                car.Weight = (float)txtWeight.Value;
                car.Note = txtGhiChu.Text.Trim();
                car.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _carRepository.Save(car);
                UnitOfWork carOfWork = new UnitOfWork(_projectDataContext);
                int result = carOfWork.Complete();
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