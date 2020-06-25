namespace NhuaTienPhong.View.Products
{
    partial class frmProduct
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
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RemainVirtual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RemainActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImportPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RetailPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Location = new System.Drawing.Point(270, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 40);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel (F4)";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(356, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Lọc (F5)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(792, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(184, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa (F3)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(98, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa (F2)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm (F1)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Location = new System.Drawing.Point(0, 50);
            this.dgvDuLieu.MainView = this.viewDuLieu;
            this.dgvDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1});
            this.dgvDuLieu.Size = new System.Drawing.Size(884, 418);
            this.dgvDuLieu.TabIndex = 1;
            this.dgvDuLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDuLieu});
            // 
            // viewDuLieu
            // 
            this.viewDuLieu.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.viewDuLieu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseForeColor = true;
            this.viewDuLieu.ColumnPanelRowHeight = 45;
            this.viewDuLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.CategoryName,
            this.ItemCode,
            this.ItemName,
            this.UnitName,
            this.SKU,
            this.RemainVirtual,
            this.RemainActual,
            this.ImportPrice,
            this.SalePrice,
            this.RetailPrice,
            this.Note,
            this.Status});
            this.viewDuLieu.DetailHeight = 284;
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 40;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 40;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
            this.viewDuLieu.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceHeader.Options.UseFont = true;
            this.Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.Caption = "Id";
            this.Id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // CategoryName
            // 
            this.CategoryName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CategoryName.AppearanceCell.Options.UseFont = true;
            this.CategoryName.AppearanceCell.Options.UseTextOptions = true;
            this.CategoryName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CategoryName.AppearanceHeader.Options.UseFont = true;
            this.CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CategoryName.Caption = "Nhóm hàng";
            this.CategoryName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.CategoryName.FieldName = "CategoryName";
            this.CategoryName.MaxWidth = 70;
            this.CategoryName.MinWidth = 70;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 0;
            this.CategoryName.Width = 70;
            // 
            // ItemCode
            // 
            this.ItemCode.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ItemCode.AppearanceCell.Options.UseFont = true;
            this.ItemCode.AppearanceCell.Options.UseTextOptions = true;
            this.ItemCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ItemCode.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ItemCode.AppearanceHeader.Options.UseFont = true;
            this.ItemCode.AppearanceHeader.Options.UseTextOptions = true;
            this.ItemCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ItemCode.Caption = "Mã hàng hóa";
            this.ItemCode.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ItemCode.FieldName = "ItemCode";
            this.ItemCode.MaxWidth = 70;
            this.ItemCode.MinWidth = 70;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Visible = true;
            this.ItemCode.VisibleIndex = 1;
            this.ItemCode.Width = 70;
            // 
            // ItemName
            // 
            this.ItemName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ItemName.AppearanceCell.Options.UseFont = true;
            this.ItemName.AppearanceCell.Options.UseTextOptions = true;
            this.ItemName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ItemName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ItemName.AppearanceHeader.Options.UseFont = true;
            this.ItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.ItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ItemName.Caption = "Tên hàng hóa";
            this.ItemName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ItemName.FieldName = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 2;
            this.ItemName.Width = 247;
            // 
            // UnitName
            // 
            this.UnitName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UnitName.AppearanceCell.Options.UseFont = true;
            this.UnitName.AppearanceCell.Options.UseTextOptions = true;
            this.UnitName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UnitName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UnitName.AppearanceHeader.Options.UseFont = true;
            this.UnitName.AppearanceHeader.Options.UseTextOptions = true;
            this.UnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitName.Caption = "ĐVT";
            this.UnitName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.UnitName.FieldName = "UnitName";
            this.UnitName.MaxWidth = 50;
            this.UnitName.MinWidth = 50;
            this.UnitName.Name = "UnitName";
            this.UnitName.Visible = true;
            this.UnitName.VisibleIndex = 3;
            this.UnitName.Width = 50;
            // 
            // SKU
            // 
            this.SKU.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SKU.AppearanceCell.Options.UseFont = true;
            this.SKU.AppearanceCell.Options.UseTextOptions = true;
            this.SKU.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SKU.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SKU.AppearanceHeader.Options.UseFont = true;
            this.SKU.AppearanceHeader.Options.UseTextOptions = true;
            this.SKU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SKU.Caption = "SKU";
            this.SKU.ColumnEdit = this.repositoryItemMemoEdit1;
            this.SKU.FieldName = "SKU";
            this.SKU.MaxWidth = 100;
            this.SKU.MinWidth = 100;
            this.SKU.Name = "SKU";
            this.SKU.Width = 100;
            // 
            // RemainVirtual
            // 
            this.RemainVirtual.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RemainVirtual.AppearanceCell.Options.UseFont = true;
            this.RemainVirtual.AppearanceCell.Options.UseTextOptions = true;
            this.RemainVirtual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainVirtual.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RemainVirtual.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RemainVirtual.AppearanceHeader.Options.UseFont = true;
            this.RemainVirtual.AppearanceHeader.Options.UseTextOptions = true;
            this.RemainVirtual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainVirtual.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RemainVirtual.Caption = "SL tổn kho ảo NTP";
            this.RemainVirtual.ColumnEdit = this.repositoryItemMemoEdit1;
            this.RemainVirtual.DisplayFormat.FormatString = "#,##0.##";
            this.RemainVirtual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.RemainVirtual.FieldName = "RemainVirtual";
            this.RemainVirtual.MaxWidth = 80;
            this.RemainVirtual.MinWidth = 80;
            this.RemainVirtual.Name = "RemainVirtual";
            this.RemainVirtual.Visible = true;
            this.RemainVirtual.VisibleIndex = 4;
            this.RemainVirtual.Width = 80;
            // 
            // RemainActual
            // 
            this.RemainActual.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RemainActual.AppearanceCell.Options.UseFont = true;
            this.RemainActual.AppearanceCell.Options.UseTextOptions = true;
            this.RemainActual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainActual.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RemainActual.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RemainActual.AppearanceHeader.Options.UseFont = true;
            this.RemainActual.AppearanceHeader.Options.UseTextOptions = true;
            this.RemainActual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainActual.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RemainActual.Caption = "SL tổn kho thực NTP";
            this.RemainActual.ColumnEdit = this.repositoryItemMemoEdit1;
            this.RemainActual.DisplayFormat.FormatString = "#,##0.##";
            this.RemainActual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.RemainActual.FieldName = "RemainActual";
            this.RemainActual.MaxWidth = 80;
            this.RemainActual.MinWidth = 80;
            this.RemainActual.Name = "RemainActual";
            this.RemainActual.Visible = true;
            this.RemainActual.VisibleIndex = 5;
            this.RemainActual.Width = 80;
            // 
            // ImportPrice
            // 
            this.ImportPrice.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ImportPrice.AppearanceCell.Options.UseFont = true;
            this.ImportPrice.AppearanceCell.Options.UseTextOptions = true;
            this.ImportPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ImportPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ImportPrice.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ImportPrice.AppearanceHeader.Options.UseFont = true;
            this.ImportPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.ImportPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ImportPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ImportPrice.Caption = "Giá nhập";
            this.ImportPrice.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ImportPrice.DisplayFormat.FormatString = "#,##0.##";
            this.ImportPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ImportPrice.FieldName = "ImportPrice";
            this.ImportPrice.MaxWidth = 80;
            this.ImportPrice.MinWidth = 80;
            this.ImportPrice.Name = "ImportPrice";
            this.ImportPrice.Width = 60;
            // 
            // SalePrice
            // 
            this.SalePrice.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SalePrice.AppearanceCell.Options.UseFont = true;
            this.SalePrice.AppearanceCell.Options.UseTextOptions = true;
            this.SalePrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SalePrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SalePrice.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SalePrice.AppearanceHeader.Options.UseFont = true;
            this.SalePrice.AppearanceHeader.Options.UseTextOptions = true;
            this.SalePrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalePrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SalePrice.Caption = "Giá bán buôn";
            this.SalePrice.ColumnEdit = this.repositoryItemMemoEdit1;
            this.SalePrice.DisplayFormat.FormatString = "#,##0.##";
            this.SalePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SalePrice.FieldName = "SalePrice";
            this.SalePrice.MaxWidth = 80;
            this.SalePrice.MinWidth = 80;
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 60;
            // 
            // RetailPrice
            // 
            this.RetailPrice.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RetailPrice.AppearanceCell.Options.UseFont = true;
            this.RetailPrice.AppearanceCell.Options.UseTextOptions = true;
            this.RetailPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.RetailPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RetailPrice.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RetailPrice.AppearanceHeader.Options.UseFont = true;
            this.RetailPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.RetailPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RetailPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RetailPrice.Caption = "Giá bán";
            this.RetailPrice.ColumnEdit = this.repositoryItemMemoEdit1;
            this.RetailPrice.DisplayFormat.FormatString = "#,##0.##";
            this.RetailPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.RetailPrice.FieldName = "RetailPrice";
            this.RetailPrice.MaxWidth = 80;
            this.RetailPrice.MinWidth = 80;
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.Visible = true;
            this.RetailPrice.VisibleIndex = 6;
            this.RetailPrice.Width = 80;
            // 
            // Note
            // 
            this.Note.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Note.AppearanceCell.Options.UseFont = true;
            this.Note.AppearanceCell.Options.UseTextOptions = true;
            this.Note.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Note.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Note.AppearanceHeader.Options.UseFont = true;
            this.Note.AppearanceHeader.Options.UseTextOptions = true;
            this.Note.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Note.Caption = "Ghi chú";
            this.Note.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Note.FieldName = "Note";
            this.Note.MaxWidth = 100;
            this.Note.MinWidth = 100;
            this.Note.Name = "Note";
            this.Note.Visible = true;
            this.Note.VisibleIndex = 7;
            this.Note.Width = 100;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Status.AppearanceCell.Options.UseFont = true;
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Status.AppearanceHeader.Options.UseFont = true;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.MaxWidth = 75;
            this.Status.MinWidth = 75;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // frmProduct
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 468);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel radPanel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn ItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitName;
        private DevExpress.XtraGrid.Columns.GridColumn SKU;
        private DevExpress.XtraGrid.Columns.GridColumn RemainActual;
        private DevExpress.XtraGrid.Columns.GridColumn RemainVirtual;
        private DevExpress.XtraGrid.Columns.GridColumn ImportPrice;
        private DevExpress.XtraGrid.Columns.GridColumn SalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn RetailPrice;
    }
}