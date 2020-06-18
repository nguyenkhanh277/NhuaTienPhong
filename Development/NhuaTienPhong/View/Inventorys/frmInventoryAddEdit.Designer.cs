namespace NhuaTienPhong.View.Inventorys
{
    partial class frmInventoryAddEdit
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chkUsing = new System.Windows.Forms.RadioButton();
            this.chkNoUse = new System.Windows.Forms.RadioButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.txtImportPrice = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddPartNumber = new System.Windows.Forms.Button();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbWarehouse = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSalePrice = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRetailPrice = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(265, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(154)))), ((int)(((byte)(242)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(179, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu (F1)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.EditValue = "";
            this.txtItemCode.Location = new System.Drawing.Point(45, 94);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtItemCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtItemCode.Properties.AutoHeight = false;
            this.txtItemCode.Size = new System.Drawing.Size(300, 30);
            this.txtItemCode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 69);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã hàng";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(45, 498);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 19);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Trạng thái";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 437);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 17);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Ghi chú";
            // 
            // chkUsing
            // 
            this.chkUsing.AutoSize = true;
            this.chkUsing.BackColor = System.Drawing.Color.Transparent;
            this.chkUsing.Checked = true;
            this.chkUsing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkUsing.Location = new System.Drawing.Point(10, 4);
            this.chkUsing.Name = "chkUsing";
            this.chkUsing.Size = new System.Drawing.Size(78, 23);
            this.chkUsing.TabIndex = 0;
            this.chkUsing.TabStop = true;
            this.chkUsing.Text = "Sử dụng";
            this.chkUsing.UseVisualStyleBackColor = false;
            // 
            // chkNoUse
            // 
            this.chkNoUse.AutoSize = true;
            this.chkNoUse.BackColor = System.Drawing.Color.Transparent;
            this.chkNoUse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkNoUse.Location = new System.Drawing.Point(94, 4);
            this.chkNoUse.Name = "chkNoUse";
            this.chkNoUse.Size = new System.Drawing.Size(97, 23);
            this.chkNoUse.TabIndex = 1;
            this.chkNoUse.Text = "Ko sử dụng";
            this.chkNoUse.UseVisualStyleBackColor = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chkUsing);
            this.panelControl2.Controls.Add(this.chkNoUse);
            this.panelControl2.Location = new System.Drawing.Point(45, 522);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(300, 30);
            this.panelControl2.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(45, 461);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Properties.Appearance.Options.UseFont = true;
            this.txtGhiChu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGhiChu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGhiChu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtGhiChu.Size = new System.Drawing.Size(300, 30);
            this.txtGhiChu.TabIndex = 7;
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtImportPrice.Location = new System.Drawing.Point(45, 280);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtImportPrice.Properties.Appearance.Options.UseFont = true;
            this.txtImportPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtImportPrice.Properties.IsFloatValue = false;
            this.txtImportPrice.Properties.Mask.EditMask = "N00";
            this.txtImportPrice.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtImportPrice.Size = new System.Drawing.Size(300, 28);
            this.txtImportPrice.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 254);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 19);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Giá nhập";
            // 
            // txtItemName
            // 
            this.txtItemName.EditValue = "";
            this.txtItemName.Location = new System.Drawing.Point(45, 157);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtItemName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtItemName.Properties.AutoHeight = false;
            this.txtItemName.Size = new System.Drawing.Size(300, 30);
            this.txtItemName.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 132);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 17);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Tên hàng";
            // 
            // btnAddPartNumber
            // 
            this.btnAddPartNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddPartNumber.BackgroundImage = global::NhuaTienPhong.Properties.Resources.Add;
            this.btnAddPartNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPartNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartNumber.Location = new System.Drawing.Point(317, 219);
            this.btnAddPartNumber.Name = "btnAddPartNumber";
            this.btnAddPartNumber.Size = new System.Drawing.Size(28, 28);
            this.btnAddPartNumber.TabIndex = 12;
            this.btnAddPartNumber.UseVisualStyleBackColor = false;
            // 
            // cbbUnit
            // 
            this.cbbUnit.DisplayMember = "PartNo";
            this.cbbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbUnit.FormattingEnabled = true;
            this.cbbUnit.Location = new System.Drawing.Point(45, 219);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(266, 28);
            this.cbbUnit.TabIndex = 3;
            this.cbbUnit.ValueMember = "Id";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 195);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 19);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Đơn vị tính";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::NhuaTienPhong.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(317, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbbWarehouse
            // 
            this.cbbWarehouse.DisplayMember = "PartNo";
            this.cbbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWarehouse.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbbWarehouse.FormattingEnabled = true;
            this.cbbWarehouse.Location = new System.Drawing.Point(45, 34);
            this.cbbWarehouse.Name = "cbbWarehouse";
            this.cbbWarehouse.Size = new System.Drawing.Size(266, 28);
            this.cbbWarehouse.TabIndex = 0;
            this.cbbWarehouse.ValueMember = "Id";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(45, 10);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 17);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Kho";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSalePrice.Location = new System.Drawing.Point(45, 341);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSalePrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSalePrice.Properties.IsFloatValue = false;
            this.txtSalePrice.Properties.Mask.EditMask = "N00";
            this.txtSalePrice.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtSalePrice.Size = new System.Drawing.Size(300, 28);
            this.txtSalePrice.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(45, 315);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 17);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Giá bán buôn";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRetailPrice.Location = new System.Drawing.Point(45, 402);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRetailPrice.Properties.Appearance.Options.UseFont = true;
            this.txtRetailPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRetailPrice.Properties.IsFloatValue = false;
            this.txtRetailPrice.Properties.Mask.EditMask = "N00";
            this.txtRetailPrice.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtRetailPrice.Size = new System.Drawing.Size(300, 28);
            this.txtRetailPrice.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(45, 376);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 19);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Giá bán lẻ";
            // 
            // frmInventoryAddEdit
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(390, 608);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbWarehouse);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnAddPartNumber);
            this.Controls.Add(this.cbbUnit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtImportPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventoryAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmInventoryAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RadioButton chkUsing;
        private System.Windows.Forms.RadioButton chkNoUse;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.SpinEdit txtImportPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btnAddPartNumber;
        private System.Windows.Forms.ComboBox cbbUnit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbWarehouse;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit txtSalePrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit txtRetailPrice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}