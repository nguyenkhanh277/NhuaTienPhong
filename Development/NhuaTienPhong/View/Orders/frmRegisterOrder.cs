﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NhuaTienPhong.Persistence;
using NhuaTienPhong.Persistence.Repositories;
using NhuaTienPhong.Core.Helper;
using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Core;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace NhuaTienPhong.View.Orders
{
    public partial class frmRegisterOrder : XtraForm
    {
        ProjectDataContext _projectDataContext;
        OrderRepository _orderRepository;
        OrderDetailRepository _orderDetailRepository;
        ProductRepository _productRepository;

        DataTable _orderDetail = new DataTable();
        bool _changed = true;

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
                btnSendOrder_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSaveOrder_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnSearchProduct_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmRegisterOrder()
        {
            InitializeComponent();
        }

        private void frmRegisterOrder_Load(object sender, EventArgs e)
        {
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            Clear();
        }

        private void SearchProduct()
        {
            _projectDataContext = new ProjectDataContext();
            _productRepository = new ProductRepository(_projectDataContext);
            dgvDuLieuInventory.DataSource = _productRepository.GetList().OrderBy(_ => _.CategoryName).ThenBy(_ => _.ItemName);

        }

        private void Clear()
        {
            _orderDetail = new DataTable();
            _orderDetail.Columns.Add("Delete", typeof(string));
            _orderDetail.Columns.Add("ProductId", typeof(string));
            _orderDetail.Columns.Add("ItemCode", typeof(string));
            _orderDetail.Columns.Add("ItemName", typeof(string));
            _orderDetail.Columns.Add("UnitId", typeof(string));
            _orderDetail.Columns.Add("UnitName", typeof(string));
            _orderDetail.Columns.Add("Quantity", typeof(float));
            _orderDetail.Columns.Add("Price", typeof(float));
            _orderDetail.Columns.Add("Total", typeof(float));
            _orderDetail.Columns.Add("RemainVirtual", typeof(float));
            _orderDetail.Columns.Add("RemainActual", typeof(float));
            LoadData(0);
            txtOrderNo.Text = "";
            dtpOrderDate.Value = DateTime.Now;
            txtCarNumberOrder.Text = "";
            txtTongTienChuaBaoGomVAT.Text = "0";
            txtVAT.Text = "10";
            txtTienVAT.Text = "0";
            txtTongTienDaBaoGomVAT.Text = "0";
            SearchProduct();
        }

        private bool CheckExist(string productId)
        {
            bool result = false;
            for (int i = 0; i < viewDuLieu.RowCount; i++)
            {
                if (viewDuLieu.GetRowCellValue(i, "ProductId").ToString() == productId)
                {
                    LoadData(i);
                    result = true;
                }
            }
            return result;
        }

        private void AddProduct()
        {
            if (CheckExist(viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "Id").ToString()))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _orderDetail.Rows.Add(new object[] {
                    "X",
                    viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "Id").ToString(),
                    viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "ItemCode").ToString(),
                    viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "ItemName").ToString(),
                    viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "UnitId").ToString(),
                    viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "UnitName").ToString(),
                    0,
                    float.Parse(viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "SalePrice").ToString()),
                    float.Parse(viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "SalePrice").ToString()),
                    float.Parse(viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "RemainVirtual").ToString()),
                    float.Parse(viewDuLieuInventory.GetRowCellValue(viewDuLieuInventory.FocusedRowHandle, "RemainActual").ToString())
                });
                Calculate(viewDuLieu.RowCount - 1);
            }
        }

        private void DeleteProduct(int rowIndex)
        {
            viewDuLieu.DeleteRow(rowIndex);
            Calculate(rowIndex - 1);
        }

        private void viewDuLieuInventory_DoubleClick(object sender, EventArgs e)
        {
            if (viewDuLieuInventory.RowCount > 0)
            {
                AddProduct();
            }
        }

        private void LoadData(int focusedRowHandle)
        {
            dgvDuLieu.DataSource = _orderDetail;
            viewDuLieu.FocusedColumn = dgcItemName;
            viewDuLieu.FocusedRowHandle = focusedRowHandle;
        }

        private void Calculate(int focusedRowHandle)
        {
            LoadData(focusedRowHandle);
            float total = 0;
            float subTotal = 0;
            for (int i = 0; i < viewDuLieu.RowCount; i++)
            {
                subTotal = (float.Parse(viewDuLieu.GetRowCellValue(i, "Quantity").ToString()) * float.Parse(viewDuLieu.GetRowCellValue(i, "Price").ToString()));
                viewDuLieu.SetRowCellValue(i, "Total", subTotal);
                total += subTotal;
            }
            txtTongTienChuaBaoGomVAT.Text = total.ToString("N0");
            txtTienVAT.Text = (total * (float)txtVAT.Value / 100).ToString("N0");
            txtTongTienDaBaoGomVAT.Text = (total * (1 + (float)txtVAT.Value / 100)).ToString("N0");
        }

        private bool CheckData()
        {
            if (txtCarNumberOrder.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarNumberOrder.Focus();
                return false;
            }
            return true;
        }

        private void Save(bool submit)
        {
            try
            {
                if (!CheckData()) return;
                _projectDataContext = new ProjectDataContext();
                _orderRepository = new OrderRepository(_projectDataContext);
                _orderDetailRepository = new OrderDetailRepository(_projectDataContext);
                _productRepository = new ProductRepository(_projectDataContext);

                //Table Order
                Order order = new Order();
                order.OrderDate = dtpOrderDate.Value;
                order.CarNumberOrder = txtCarNumberOrder.Text.Trim();
                order.UseCarStatus = (chkCompany.Checked ? GlobalConstants.UseCarStatusValue.Company : GlobalConstants.UseCarStatusValue.Agency);
                order.Total = float.Parse(txtTongTienChuaBaoGomVAT.Text);
                order.VAT = (float)txtVAT.Value;
                order.VATMoney = float.Parse(txtTienVAT.Text);
                order.ProcessingCarStatus = GlobalConstants.ProcessingCarStatusValue.None;
                order.ProcessingStatus = (submit ? GlobalConstants.ProcessingStatusValue.WaitApprove : GlobalConstants.ProcessingStatusValue.None);
                _orderRepository.Save(order);
                txtOrderNo.Text = _orderRepository.id;
                for (int i = 0; i < viewDuLieu.RowCount; i++)
                {
                    //Table OrderDetail
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderId = txtOrderNo.Text;
                    orderDetail.ItemId = viewDuLieu.GetRowCellValue(i, "ProductId").ToString();
                    orderDetail.Quantity = float.Parse(viewDuLieu.GetRowCellValue(i, "Quantity").ToString());
                    orderDetail.Price = float.Parse(viewDuLieu.GetRowCellValue(i, "Price").ToString());
                    orderDetail.Discount = 0;
                    orderDetail.DiscountMoney = 0;
                    _orderDetailRepository.Save(orderDetail);

                    //Table Product
                    _productRepository.CaculateRemainVirtual(viewDuLieu.GetRowCellValue(i, "ProductId").ToString(), float.Parse(viewDuLieu.GetRowCellValue(i, "Quantity").ToString()));
                }
                UnitOfWork productOfWork = new UnitOfWork(_projectDataContext);
                int result = productOfWork.Complete();
                if (result > 0)
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                    Clear();
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

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            Save(true);
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            Save(false);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewDuLieu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.FieldName == "Delete")
                DeleteProduct(e.RowHandle);
        }

        private void viewDuLieu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void viewDuLieu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (_changed && e.Column.FieldName == "Quantity" && (e.Value == null || String.IsNullOrEmpty(e.Value.ToString())))
            {
                _changed = false;
                view.SetRowCellValue(e.RowHandle, "Quantity", 0);
                _changed = true;
            }
        }
    }
}