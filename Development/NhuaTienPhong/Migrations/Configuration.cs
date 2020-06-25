using NhuaTienPhong.Core.Domain;
using NhuaTienPhong.Persistence;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NhuaTienPhong.Migrations
{
    using NhuaTienPhong.Core;
    using NhuaTienPhong.Core.Helper;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NhuaTienPhong.Persistence.ProjectDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectDataContext projectDataContext)
        {
            FirstUpdate(projectDataContext);
            AddOrUpdateLanguageLibrary(projectDataContext);
        }

        private void AddOrUpdateLanguageLibrary(ProjectDataContext projectDataContext)
        {
            #region LanguageLibrary
            var languageLibrarys = new List<LanguageLibrary>
            {
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Phải sử dụng máy đọc mã vạch",
                    English = "Must use barcode reader",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bạn không có quyền sử dụng chức năng này",
                    English = "You do not have permission to use this function",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ứng dụng cần kết nối mạng để kích hoạt",
                    English = "The application requires a network connection to activate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ứng dụng cần quyền Quản trị để kích hoạt",
                    English = "Application needs Admin rights to activate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng ký sử dụng phần mềm",
                    English = "Register to use the software",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dùng thử",
                    English = "Trial",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dùng thử cho 1 máy tính",
                    English = "Try it on 1 computer",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bản quyền",
                    English = "License",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã sản phẩm",
                    English = "Product code",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày kích hoạt",
                    English = "Activation date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày hết hạn",
                    English = "Expiration date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Còn lại",
                    English = "Left day",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Sau thời gian chỉ định chương trình sẽ bị vô hiệu",
                    English = "After the specified time the program will be disabled",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Để tiếp tục sử dụng, bạn nên mua giấy phép",
                    English = "To continue using, you should purchase a license",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng ký",
                    English = "Registration",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Cổng COM",
                    English = "Port COM",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên công ty",
                    English = "Company name",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên máy in",
                    English = "Printer name",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Cấu hình",
                    English = "Setting",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng mã vạch đã in",
                    English = "Number of barcodes printed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "SL sản phẩm đã sản xuất",
                    English = "Number of products produced",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng sản phẩm OK",
                    English = "Quantity of products OK",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng sản phẩm NG",
                    English = "Quantity of products NG",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày",
                    English = "DateTime",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày sản xuất",
                    English = "Produced date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Kết quả sản xuất",
                    English = "Produced result",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Từ ngày",
                    English = "FromDate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đến ngày",
                    English = "ToDate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "In thất bại",
                    English = "Print failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thông báo",
                    English = "Notification",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xác nhận",
                    English = "Confirmation",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng nhập",
                    English = "Sign In",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tài khoản",
                    English = "Username",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu",
                    English = "Password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu thông tin đăng nhập",
                    English = "Keep me signed in",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quên mật khẩu",
                    English = "I forgot my password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu không đúng",
                    English = "Incorrect password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tài khoản không tồn tại",
                    English = "Username does not exist",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chương trình chính",
                    English = "Main Menu",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Hệ thống",
                    English = "System",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Danh mục",
                    English = "Category",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chức năng",
                    English = "Function",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Báo cáo",
                    English = "Report",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quản lý người dùng",
                    English = "User management",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Người dùng",
                    English = "Function",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đổi mật khẩu",
                    English = "Change password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngôn ngữ",
                    English = "Language",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Danh sách máy",
                    English = "Machines List",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Danh sách khuôn",
                    English = "Molds List",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Danh sách ca",
                    English = "Shifts List",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quản lý PartNumber",
                    English = "PartNumber Management",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng ký in mã vạch",
                    English = "Register to print barcode",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quét mã vạch sản phẩm",
                    English = "Scan the product barcode",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu cũ",
                    English = "Old password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu mới",
                    English = "New password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xác nhận mật khẩu",
                    English = "Confirm password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thư viện ngôn ngữ",
                    English = "Language Library",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thêm (F1)",
                    English = "Add (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Sửa (F2)",
                    English = "Edit (F2)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xóa (F3)",
                    English = "Del (F3)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Excel (F4)",
                    English = "Excel (F4)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lọc (F5)",
                    English = "Refresh (F5)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Phân quyền (F6)",
                    English = "Authority (F6)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chương trình (F7)",
                    English = "Program(F7)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu (F1)",
                    English = "Save (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đóng (ESC)",
                    English = "Close (ESC)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Trạng thái",
                    English = "Status",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tất cả",
                    English = "All",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Sử dụng",
                    English = "Using",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ko sử dụng",
                    English = "No User",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Giới tính",
                    English = "Gender",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Nam",
                    English = "Male",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Nữ",
                    English = "Female",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên đầy đủ",
                    English = "FullName",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Điện thoại",
                    English = "Phone",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Địa chỉ",
                    English = "Address",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ghi chú",
                    English = "Note",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chọn",
                    English = "Select",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã",
                    English = "ID",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Nhóm quyền",
                    English = "Authority Group",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tiếng Việt",
                    English = "Vietnamese",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tiếng Anh",
                    English = "English",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chức năng chương trình",
                    English = "Program Function Master",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chương trình",
                    English = "Program",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Diễn giải",
                    English = "Explanation",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chưa điền dữ liệu",
                    English = "No data entered",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chưa chọn dữ liệu",
                    English = "No data selected",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dữ liệu đã tồn tại",
                    English = "Data already exists",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dữ liệu không đúng",
                    English = "The data is incorrect",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã máy",
                    English = "Machine No",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên máy",
                    English = "Machine Name",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã khuôn",
                    English = "Mold No",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã ca",
                    English = "Shift No",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "In lại (F2)",
                    English = "RePrint (F2)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu thành công",
                    English = "Save successfully",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu thất bại",
                    English = "Save failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bạn có muốn hủy thông tin này?",
                    English = "Do you want to cancel this information?",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bạn có muốn xóa thông tin này?",
                    English = "Do you want to delete this information?",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Hủy thất bại",
                    English = "Cancel failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xóa thất bại",
                    English = "Delete failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày đăng ký",
                    English = "Regist date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày quét mã vạch",
                    English = "Scan barcode date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã vạch",
                    English = "Barcode",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu và in (F1)",
                    English = "Save and Print (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lịch sử sản xuất",
                    English = "Production history",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thống kê sản phẩm OK",
                    English = "Product report OK",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thống kê sản phẩm NG",
                    English = "Product report NG",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Báo cáo tổng hợp theo mã vạch",
                    English = "Report synthetic by barcode",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Báo cáo tổng hợp theo kế hoạch",
                    English = "Report synthetic by plan",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Trạng thái sản xuất",
                    English = "Production Status",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quét mã vạch (F1)",
                    English = "Scan barcode (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Kế hoạch sản xuất",
                    English = "Production plan",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày dự kiến giao hàng",
                    English = "Expected Delivery Date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng",
                    English = "Quantity",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Trạng thái sản xuất",
                    English = "Production Status",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chưa xử lý",
                    English = "None",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đang xử lý",
                    English = "In progress",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đã xong",
                    English = "Completed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bảo lưu",
                    English = "Hold",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đã bị hủy",
                    English = "NoUse",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đang dùng",
                    English = "Using",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var languageLibrary in languageLibrarys)
                projectDataContext.LanguageLibrarys.AddOrUpdate(a => a.Id, languageLibrary);
            #endregion
        }

        private void FirstUpdate(ProjectDataContext projectDataContext)
        {
            //return;
            string defaultPassword1 = "1511";
            string defaultPassword2 = "quanly";
            string defaultPassword3 = "ca1";
            string defaultPassword4 = "ca2";
            string salt = SecurityHelper.CreateSalt(GlobalConstants.defaultSaltLength);
            string encryptedPassword1 = SecurityHelper.GenerateMD5(defaultPassword1, salt);
            string encryptedPassword2 = SecurityHelper.GenerateMD5(defaultPassword2, salt);
            string encryptedPassword3 = SecurityHelper.GenerateMD5(defaultPassword3, salt);
            string encryptedPassword4 = SecurityHelper.GenerateMD5(defaultPassword4, salt);

            #region Add Users
            string userID1 = Guid.NewGuid().ToString();
            string userID2 = Guid.NewGuid().ToString();
            string userID3 = Guid.NewGuid().ToString();
            string userID4 = Guid.NewGuid().ToString();
            var users = new List<User>
            {
                new User
                {
                    Id = userID1,
                    Username = "admin",
                    Salt = salt,
                    Password = encryptedPassword1,
                    FullName = "Administrator",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID2,
                    Username = "quanly",
                    Salt = salt,
                    Password = encryptedPassword2,
                    FullName = "Quản lý",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID3,
                    Username = "ca1",
                    Salt = salt,
                    Password = encryptedPassword3,
                    FullName = "Ca 1",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID4,
                    Username = "ca2",
                    Salt = salt,
                    Password = encryptedPassword4,
                    FullName = "Ca 2",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var user in users)
                projectDataContext.Users.AddOrUpdate(a => a.Id, user);
            #endregion


            #region Add AuthorityGroup
            string authorityGroup1 = Guid.NewGuid().ToString();
            string authorityGroup2 = Guid.NewGuid().ToString();
            string authorityGroup3 = Guid.NewGuid().ToString();
            var authorityGroups = new List<AuthorityGroup>
            {
                new AuthorityGroup
                {
                    Id = authorityGroup1,
                    AuthorityGroupName = "Admin",
                    Sort = 0,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new AuthorityGroup
                {
                    Id = authorityGroup2,
                    AuthorityGroupName = "Manager",
                    Sort = 1,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new AuthorityGroup
                {
                    Id = authorityGroup3,
                    AuthorityGroupName = "Operator",
                    Sort = 2,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var authorityGroup in authorityGroups)
                projectDataContext.AuthorityGroups.Add(authorityGroup);
            #endregion


            #region Add ProgramFunctionMaster
            var programFunctionMasters = new List<ProgramFunctionMaster>
            {
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Language",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Setting",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Agency",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Car",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Warehouse",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Unit",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Inventory",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "RegistOrder",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProcessingOrder",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "MergeCar",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ListProcessing",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ConfirmOrder",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "SyncVsBravo",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var programFunctionMaster in programFunctionMasters)
                projectDataContext.ProgramFunctionMasters.AddOrUpdate(a => a.Id, programFunctionMaster);
            #endregion


            #region Add ProgramFunctionAuthority
            var programFunctionAuthoritys = new List<ProgramFunctionAuthority>
            {
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Language",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Setting",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Agency",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Car",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Warehouse",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Unit",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Inventory",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "RegistOrder",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProcessingOrder",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "MergeCar",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ListProcessing",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ConfirmOrder",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "SyncVsBravo",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Language",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Setting",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Agency",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Car",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Warehouse",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Unit",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Inventory",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "RegistOrder",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProcessingOrder",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "MergeCar",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ListProcessing",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ConfirmOrder",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "SyncVsBravo",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };


            foreach (var programFunctionAuthority in programFunctionAuthoritys)
                projectDataContext.ProgramFunctionAuthoritys.AddOrUpdate(a => a.Id, programFunctionAuthority);
            #endregion


            #region Add UserAuthority
            var userAuthoritys = new List<UserAuthority>
            {
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID1,
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID2,
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID3,
                    AuthorityGroupID = authorityGroup3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID4,
                    AuthorityGroupID = authorityGroup3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var userAuthority in userAuthoritys)
                projectDataContext.UserAuthoritys.AddOrUpdate(a => a.Id, userAuthority);
            #endregion


            #region Add Agency
            var agencys = new List<Agency>
            {
                new Agency
                {
                    Id = Guid.NewGuid().ToString(),
                    AgencyName = "Mặc định",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var agency in agencys)
                projectDataContext.Agencys.Add(agency);
            #endregion


            #region Add Car
            var cars = new List<Car>
            {
                new Car
                {
                    Id = Guid.NewGuid().ToString(),
                    CarNumber = "16N-9999",
                    Driver = "Nguyễn Xuân Trường",
                    Weight = 0,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var car in cars)
                projectDataContext.Cars.Add(car);
            #endregion


            #region Add Warhouse
            string warehouse0 = "K0";
            string warehouse1 = "K1";
            string warehouse2 = "K2";
            string warehouse3 = "K3";
            string warehouse4 = "K4";
            string warehouse5 = "K5";
            string warehouse6 = "K6";
            string warehouse7 = "K7";
            var warehouses = new List<Warehouse>
            {
                new Warehouse
                {
                    Id = warehouse0,
                    WarehouseName = "Kho NTP",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse1,
                    WarehouseName = "Kho 1",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse2,
                    WarehouseName = "Kho 2",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse3,
                    WarehouseName = "Kho 3",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse4,
                    WarehouseName = "Kho 4",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse5,
                    WarehouseName = "Kho 5",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse6,
                    WarehouseName = "Kho 6",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Warehouse
                {
                    Id = warehouse7,
                    WarehouseName = "Kho 7",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var warehouse in warehouses)
                projectDataContext.Warehouses.Add(warehouse);
            #endregion


            #region Add Unit
            string unit1 = Guid.NewGuid().ToString();
            string unit2 = Guid.NewGuid().ToString();
            string unit3 = Guid.NewGuid().ToString();
            var units = new List<Unit>
            {
                new Unit
                {
                    Id = unit1,
                    UnitName = "Cái",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Unit
                {
                    Id = unit2,
                    UnitName = "Chiếc",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Unit
                {
                    Id = unit3,
                    UnitName = "Hộp",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var unit in units)
                projectDataContext.Units.Add(unit);
            #endregion


            #region Add Category
            string category1 = Guid.NewGuid().ToString();
            var categorys = new List<Category>
            {
                new Category
                {
                    Id = category1,
                    CategoryName = "Mặc định",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var category in categorys)
                projectDataContext.Categorys.Add(category);
            #endregion


            #region Add Product
            string product1 = Guid.NewGuid().ToString();
            string product2 = Guid.NewGuid().ToString();
            string product3 = Guid.NewGuid().ToString();
            var products = new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    CategoryId = category1,
                    ItemCode = "K0-00001",
                    ItemName = "Côn 25",
                    UnitId = unit1,
                    RemainActual = 0,
                    RemainVirtual = 0,
                    ImportPrice = 10000,
                    SalePrice = 11000,
                    RetailPrice = 12000,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    CategoryId = category1,
                    ItemCode = "K0-00002",
                    ItemName = "Côn 30",
                    UnitId = unit1,
                    RemainActual = 0,
                    RemainVirtual = 0,
                    ImportPrice = 10000,
                    SalePrice = 11000,
                    RetailPrice = 12000,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    CategoryId = category1,
                    ItemCode = "K0-00003",
                    ItemName = "Côn 40",
                    UnitId = unit1,
                    RemainActual = 0,
                    RemainVirtual = 0,
                    ImportPrice = 10000,
                    SalePrice = 11000,
                    RetailPrice = 12000,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var product in products)
                projectDataContext.Products.Add(product);
            #endregion
        }
    }
}
