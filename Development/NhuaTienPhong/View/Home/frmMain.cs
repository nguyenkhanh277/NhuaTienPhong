using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using NhuaTienPhong.Core;
using NhuaTienPhong.Core.Helper;
using NhuaTienPhong.Persistence;
using NhuaTienPhong.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace NhuaTienPhong.View.Home
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        #region SkinGallery
        void InitSkinGallery()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void rgbiSkins_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {

            Properties.Settings.Default.Theme = e.Item.Value.ToString();
            Properties.Settings.Default.Save();
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository(_projectDataContext);
            this.Icon = Properties.Resources.icon;
            this.Text = LanguageTranslate.ChangeLanguageText(this.Text);
            Translate();
            Permission();
            ribbonControl1.SelectPage(rbpChucNang);
        }

        private void Translate()
        {
            btnUsers.Caption = LanguageTranslate.ChangeLanguageText(btnUsers.Caption);
            btnChangePassword.Caption = LanguageTranslate.ChangeLanguageText(btnChangePassword.Caption);
            btnLanguageLibrary.Caption = LanguageTranslate.ChangeLanguageText(btnLanguageLibrary.Caption);
            btnSetting.Caption = LanguageTranslate.ChangeLanguageText(btnSetting.Caption);

            btnAgency.Caption = LanguageTranslate.ChangeLanguageText(btnAgency.Caption);
            btnCar.Caption = LanguageTranslate.ChangeLanguageText(btnCar.Caption);
            btnWarehouse.Caption = LanguageTranslate.ChangeLanguageText(btnWarehouse.Caption);
            btnUnit.Caption = LanguageTranslate.ChangeLanguageText(btnUnit.Caption);
            btnInventory.Caption = LanguageTranslate.ChangeLanguageText(btnInventory.Caption);

            btnRegistOrder.Caption = LanguageTranslate.ChangeLanguageText(btnRegistOrder.Caption);
            btnProcessingOrder.Caption = LanguageTranslate.ChangeLanguageText(btnProcessingOrder.Caption);
            btnMergeCar.Caption = LanguageTranslate.ChangeLanguageText(btnMergeCar.Caption);
            btnListProcessing.Caption = LanguageTranslate.ChangeLanguageText(btnListProcessing.Caption);
            btnConfirmOrder.Caption = LanguageTranslate.ChangeLanguageText(btnConfirmOrder.Caption);
            btnSyncVsBravo.Caption = LanguageTranslate.ChangeLanguageText(btnSyncVsBravo.Caption);

            btnProductReportOK.Caption = LanguageTranslate.ChangeLanguageText(btnProductReportOK.Caption);
            btnProductReportNG.Caption = LanguageTranslate.ChangeLanguageText(btnProductReportNG.Caption);
            btnReportSyntheticRegistBarcode.Caption = LanguageTranslate.ChangeLanguageText(btnReportSyntheticRegistBarcode.Caption);
            btnReportSyntheticProductionPlan.Caption = LanguageTranslate.ChangeLanguageText(btnReportSyntheticProductionPlan.Caption);
            rbpHeThong.Text = LanguageTranslate.ChangeLanguageText(rbpHeThong.Text);
            rbpDanhMuc.Text = LanguageTranslate.ChangeLanguageText(rbpDanhMuc.Text);
            rbpChucNang.Text = LanguageTranslate.ChangeLanguageText(rbpChucNang.Text);
            rbpBaoCao.Text = LanguageTranslate.ChangeLanguageText(rbpBaoCao.Text);

            txtUser.Caption = LanguageTranslate.ChangeLanguageText("Tài khoản") + ": " + GlobalConstants.username + "  |  " + LanguageTranslate.ChangeLanguageText("Tên đầy đủ") + ": " + GlobalConstants.fullName;
        }

        private void Permission()
        {
            btnUsers.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "User", "View");
            btnLanguageLibrary.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Language", "View");
            btnSetting.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Setting", "View");

            btnAgency.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Agency", "View");
            btnCar.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Car", "View");
            btnWarehouse.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Warehouse", "View");
            btnUnit.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Unit", "View");
            btnInventory.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Inventory", "View");

            btnRegistOrder.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "RegistOrder", "View");
            btnProcessingOrder.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ProcessingOrder", "View");
            btnMergeCar.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "MergeCar", "View");
            btnListProcessing.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ListProcessing", "View");
            btnConfirmOrder.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ConfirmOrder", "View");
            btnSyncVsBravo.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "SyncVsBravo", "View");

            btnProductReportOK.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "QuantityOfProductsOK", "View");
            btnProductReportNG.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "QuantityOfProductsNG", "View");
            btnReportSyntheticRegistBarcode.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ReportSyntheticRegistBarcode", "View");
            btnReportSyntheticProductionPlan.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ReportSyntheticProductionPlan", "View");
        }

        private XtraForm CheckExist(Type fType)
        {
            foreach (XtraForm f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Users.frmUsers));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Users.frmUsers f = new Users.frmUsers();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnLanguageLibrary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(LanguageLibrarys.frmLanguageLibrary));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                LanguageLibrarys.frmLanguageLibrary f = new LanguageLibrarys.frmLanguageLibrary();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }

        private void btnAgency_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Agencys.frmAgency));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Agencys.frmAgency f = new Agencys.frmAgency();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Cars.frmCar));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Cars.frmCar f = new Cars.frmCar();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Warehouses.frmWarehouse));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Warehouses.frmWarehouse f = new Warehouses.frmWarehouse();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Units.frmUnit));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Units.frmUnit f = new Units.frmUnit();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Inventorys.frmInventory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Inventorys.frmInventory f = new Inventorys.frmInventory();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnProductReportOK_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnProductReportNG_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btnReportSyntheticRegistBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void btnReportSyntheticProductionPlan_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnRegistOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnProcessingOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnMergeCar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnListProcessing_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnConfirmOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSyncVsBravo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
