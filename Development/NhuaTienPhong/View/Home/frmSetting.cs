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
using NhuaTienPhong.Core.Helper;
using System.Drawing.Printing;

namespace NhuaTienPhong.View.Home
{
    public partial class frmSetting : DevExpress.XtraEditors.XtraForm
    {
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

        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            LanguageTranslate.ChangeLanguageForm(this);
            LoadPrinter(); 
            txtCompany.Text = Properties.Settings.Default.Company;
            txtAddress.Text = Properties.Settings.Default.Address;
            txtPhone.Text = Properties.Settings.Default.Phone;
            cbbPrinter.Text = (GeneralHelper.ValidPrinter(Properties.Settings.Default.PrinterName) ? Properties.Settings.Default.PrinterName : "");
        }

        private void LoadPrinter()
        {
            cbbPrinter.Items.Clear();
            try
            {
                cbbPrinter.Items.Add("");
                foreach (string installedPrinters in PrinterSettings.InstalledPrinters)
                {
                    cbbPrinter.Items.Add(installedPrinters);
                }
            }
            catch { }
        }

        private bool CheckData()
        {
            if (txtCompany.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompany.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;
            Properties.Settings.Default.Company = txtCompany.Text.Trim();
            Properties.Settings.Default.Address = txtAddress.Text.Trim();
            Properties.Settings.Default.Phone = txtPhone.Text.Trim();
            Properties.Settings.Default.PrinterName = cbbPrinter.Text.Trim();
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}