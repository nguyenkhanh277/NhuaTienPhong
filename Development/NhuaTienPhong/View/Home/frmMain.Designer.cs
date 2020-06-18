using DevExpress.XtraBars;

namespace NhuaTienPhong.View.Home
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.txtUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnLanguageLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnRegistOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnMergeCar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCar = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnit = new DevExpress.XtraBars.BarButtonItem();
            this.btnWarehouse = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgency = new DevExpress.XtraBars.BarButtonItem();
            this.btnListProcessing = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductReportOK = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductReportNG = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportSyntheticRegistBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcessingOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportSyntheticProductionPlan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnInventory = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnConfirmOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnSyncVsBravo = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barStaticItem1);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnUsers,
            this.btnChangePassword,
            this.txtUser,
            this.btnLanguageLibrary,
            this.rgbiSkins,
            this.btnRegistOrder,
            this.btnMergeCar,
            this.btnCar,
            this.btnUnit,
            this.btnWarehouse,
            this.btnAgency,
            this.btnListProcessing,
            this.btnProductReportOK,
            this.btnProductReportNG,
            this.btnReportSyntheticRegistBarcode,
            this.btnProcessingOrder,
            this.btnReportSyntheticProductionPlan,
            this.btnSetting,
            this.btnInventory,
            this.btnConfirmOrder,
            this.btnSyncVsBravo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 46;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.txtUser);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpDanhMuc,
            this.rbpChucNang,
            this.rbpBaoCao});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1014, 143);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Copyright by Datatech.vn - Phone: 08 8822 2329 - Email: contact@datatech.vn";
            this.barStaticItem1.Id = 42;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Quản lý người dùng";
            this.btnUsers.Id = 11;
            this.btnUsers.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Users;
            this.btnUsers.LargeWidth = 100;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 12;
            this.btnChangePassword.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.ChangePassword;
            this.btnChangePassword.LargeWidth = 100;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // txtUser
            // 
            this.txtUser.Caption = "     ";
            this.txtUser.Id = 18;
            this.txtUser.Name = "txtUser";
            // 
            // btnLanguageLibrary
            // 
            this.btnLanguageLibrary.Caption = "Ngôn ngữ";
            this.btnLanguageLibrary.Id = 19;
            this.btnLanguageLibrary.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Translate;
            this.btnLanguageLibrary.LargeWidth = 100;
            this.btnLanguageLibrary.Name = "btnLanguageLibrary";
            this.btnLanguageLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLanguageLibrary_ItemClick);
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Id = 13;
            this.rgbiSkins.Name = "rgbiSkins";
            this.rgbiSkins.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiSkins_GalleryItemClick);
            // 
            // btnRegistOrder
            // 
            this.btnRegistOrder.Caption = "Đăng ký đơn hàng";
            this.btnRegistOrder.Id = 26;
            this.btnRegistOrder.LargeWidth = 100;
            this.btnRegistOrder.Name = "btnRegistOrder";
            this.btnRegistOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegistOrder_ItemClick);
            // 
            // btnMergeCar
            // 
            this.btnMergeCar.Caption = "Ghép xe";
            this.btnMergeCar.Id = 27;
            this.btnMergeCar.LargeWidth = 100;
            this.btnMergeCar.Name = "btnMergeCar";
            this.btnMergeCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMergeCar_ItemClick);
            // 
            // btnCar
            // 
            this.btnCar.Caption = "Xe";
            this.btnCar.Id = 31;
            this.btnCar.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Car;
            this.btnCar.LargeWidth = 100;
            this.btnCar.Name = "btnCar";
            this.btnCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCar_ItemClick);
            // 
            // btnUnit
            // 
            this.btnUnit.Caption = "Đơn vị tính";
            this.btnUnit.Id = 32;
            this.btnUnit.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Unit;
            this.btnUnit.LargeWidth = 115;
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnit_ItemClick);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Caption = "Kho";
            this.btnWarehouse.Id = 33;
            this.btnWarehouse.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Warehouse;
            this.btnWarehouse.LargeWidth = 100;
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWarehouse_ItemClick);
            // 
            // btnAgency
            // 
            this.btnAgency.Caption = "Đại lý";
            this.btnAgency.Id = 34;
            this.btnAgency.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Agency;
            this.btnAgency.LargeWidth = 100;
            this.btnAgency.Name = "btnAgency";
            this.btnAgency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgency_ItemClick);
            // 
            // btnListProcessing
            // 
            this.btnListProcessing.Caption = "Lịch bốc hàng";
            this.btnListProcessing.Id = 35;
            this.btnListProcessing.LargeWidth = 100;
            this.btnListProcessing.Name = "btnListProcessing";
            this.btnListProcessing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListProcessing_ItemClick);
            // 
            // btnProductReportOK
            // 
            this.btnProductReportOK.Caption = "Thống kê sản phẩm OK";
            this.btnProductReportOK.Id = 36;
            this.btnProductReportOK.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.ScanBarcodeOK;
            this.btnProductReportOK.LargeWidth = 100;
            this.btnProductReportOK.Name = "btnProductReportOK";
            this.btnProductReportOK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductReportOK_ItemClick);
            // 
            // btnProductReportNG
            // 
            this.btnProductReportNG.Caption = "Thống kê sản phẩm NG";
            this.btnProductReportNG.Id = 37;
            this.btnProductReportNG.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.ScanBarcodeNG;
            this.btnProductReportNG.LargeWidth = 100;
            this.btnProductReportNG.Name = "btnProductReportNG";
            this.btnProductReportNG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductReportNG_ItemClick);
            // 
            // btnReportSyntheticRegistBarcode
            // 
            this.btnReportSyntheticRegistBarcode.Caption = "Báo cáo tổng hợp theo mã vạch";
            this.btnReportSyntheticRegistBarcode.Id = 38;
            this.btnReportSyntheticRegistBarcode.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.ReportSyntheticRegistBarcode;
            this.btnReportSyntheticRegistBarcode.LargeWidth = 100;
            this.btnReportSyntheticRegistBarcode.Name = "btnReportSyntheticRegistBarcode";
            this.btnReportSyntheticRegistBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportSyntheticRegistBarcode_ItemClick);
            // 
            // btnProcessingOrder
            // 
            this.btnProcessingOrder.Caption = "Duyệt đơn hàng";
            this.btnProcessingOrder.Id = 39;
            this.btnProcessingOrder.LargeWidth = 100;
            this.btnProcessingOrder.Name = "btnProcessingOrder";
            this.btnProcessingOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcessingOrder_ItemClick);
            // 
            // btnReportSyntheticProductionPlan
            // 
            this.btnReportSyntheticProductionPlan.Caption = "Báo cáo tổng hợp theo kế hoạch";
            this.btnReportSyntheticProductionPlan.Id = 40;
            this.btnReportSyntheticProductionPlan.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.ReportSyntheticProductionPlan;
            this.btnReportSyntheticProductionPlan.LargeWidth = 100;
            this.btnReportSyntheticProductionPlan.Name = "btnReportSyntheticProductionPlan";
            this.btnReportSyntheticProductionPlan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportSyntheticProductionPlan_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "Cấu hình";
            this.btnSetting.Id = 41;
            this.btnSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.LargeImage")));
            this.btnSetting.LargeWidth = 100;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // btnInventory
            // 
            this.btnInventory.Caption = "Hàng hóa";
            this.btnInventory.Id = 43;
            this.btnInventory.ImageOptions.LargeImage = global::NhuaTienPhong.Properties.Resources.Inventory;
            this.btnInventory.LargeWidth = 100;
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInventory_ItemClick);
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLanguageLibrary);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.rgbiSkins);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAgency);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCar);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnWarehouse);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUnit);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnInventory);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpChucNang
            // 
            this.rbpChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpChucNang.Name = "rbpChucNang";
            this.rbpChucNang.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRegistOrder);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProcessingOrder);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMergeCar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListProcessing);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnConfirmOrder);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSyncVsBravo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductReportOK);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductReportNG);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportSyntheticRegistBarcode);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportSyntheticProductionPlan);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Caption = "Xác nhận bốc hàng";
            this.btnConfirmOrder.Id = 44;
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfirmOrder_ItemClick);
            // 
            // btnSyncVsBravo
            // 
            this.btnSyncVsBravo.Caption = "Đồng bộ với Bravo";
            this.btnSyncVsBravo.Id = 45;
            this.btnSyncVsBravo.Name = "btnSyncVsBravo";
            this.btnSyncVsBravo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSyncVsBravo_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 379);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chương trình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem btnUsers;
        private BarButtonItem btnChangePassword;
        private BarStaticItem txtUser;
        private BarButtonItem btnLanguageLibrary;
        private RibbonGalleryBarItem rgbiSkins;
        private BarButtonItem btnRegistOrder;
        private BarButtonItem btnMergeCar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem btnCar;
        private BarButtonItem btnUnit;
        private BarButtonItem btnWarehouse;
        private BarButtonItem btnAgency;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private BarButtonItem btnListProcessing;
        private BarButtonItem btnProductReportOK;
        private BarButtonItem btnProductReportNG;
        private BarButtonItem btnReportSyntheticRegistBarcode;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private BarButtonItem btnProcessingOrder;
        private BarButtonItem btnReportSyntheticProductionPlan;
        private BarButtonItem btnSetting;
        private BarStaticItem barStaticItem1;
        private BarButtonItem btnInventory;
        private BarButtonItem btnConfirmOrder;
        private BarButtonItem btnSyncVsBravo;
    }
}

