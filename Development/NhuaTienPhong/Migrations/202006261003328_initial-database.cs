namespace NhuaTienPhong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agencies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AgencyName = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AuthorityGroups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AuthorityGroupName = c.String(),
                        Sort = c.Int(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramFunctionAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProgramName = c.String(),
                        FunctionName = c.String(),
                        AuthorityGroupID = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupID)
                .Index(t => t.AuthorityGroupID);
            
            CreateTable(
                "dbo.UserAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserID = c.String(maxLength: 128),
                        AuthorityGroupID = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.AuthorityGroupID);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CarNumber = c.String(),
                        Driver = c.String(),
                        Weight = c.Single(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        WarehouseId = c.String(nullable: false, maxLength: 128),
                        ProductId = c.String(nullable: false, maxLength: 128),
                        RemainVirtual = c.Single(nullable: false),
                        RemainActual = c.Single(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                        Category_Id = c.String(maxLength: 128),
                        Unit_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.WarehouseId, t.ProductId })
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Units", t => t.Unit_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Unit_Id);
            
            CreateTable(
                "dbo.LanguageLibraries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Vietnamese = c.String(),
                        English = c.String(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderId = c.String(),
                        WarehouseId = c.String(),
                        ItemId = c.String(),
                        Quantity = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        Discount = c.Single(nullable: false),
                        DiscountMoney = c.Single(nullable: false),
                        Note = c.String(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OrderDate = c.DateTime(nullable: false),
                        CarNumberOrder = c.String(),
                        UseCarStatus = c.Int(nullable: false),
                        Total = c.Single(nullable: false),
                        VAT = c.Single(nullable: false),
                        VATMoney = c.Single(nullable: false),
                        SEQ = c.String(),
                        ProcessingCarStatus = c.Int(nullable: false),
                        CarNumber = c.String(),
                        Driver = c.String(),
                        ApprovalDate = c.DateTime(),
                        ProcessingStatus = c.Int(nullable: false),
                        OrderNoMerge = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CategoryId = c.String(),
                        ItemCode = c.String(),
                        ItemName = c.String(),
                        UnitId = c.String(),
                        SKU = c.String(),
                        RemainVirtual = c.Single(nullable: false),
                        RemainActual = c.Single(nullable: false),
                        ImportPrice = c.Single(nullable: false),
                        SalePrice = c.Single(nullable: false),
                        RetailPrice = c.Single(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramFunctionMasters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProgramName = c.String(),
                        FunctionName = c.String(),
                        Explanation = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UnitName = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Salt = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Gender = c.Int(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        WarehouseName = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAuthorities", "UserID", "dbo.Users");
            DropForeignKey("dbo.Inventories", "Unit_Id", "dbo.Units");
            DropForeignKey("dbo.Inventories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.UserAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropForeignKey("dbo.ProgramFunctionAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropIndex("dbo.Inventories", new[] { "Unit_Id" });
            DropIndex("dbo.Inventories", new[] { "Category_Id" });
            DropIndex("dbo.UserAuthorities", new[] { "AuthorityGroupID" });
            DropIndex("dbo.UserAuthorities", new[] { "UserID" });
            DropIndex("dbo.ProgramFunctionAuthorities", new[] { "AuthorityGroupID" });
            DropTable("dbo.Warehouses");
            DropTable("dbo.Users");
            DropTable("dbo.Units");
            DropTable("dbo.ProgramFunctionMasters");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.LanguageLibraries");
            DropTable("dbo.Inventories");
            DropTable("dbo.Categories");
            DropTable("dbo.Cars");
            DropTable("dbo.UserAuthorities");
            DropTable("dbo.ProgramFunctionAuthorities");
            DropTable("dbo.AuthorityGroups");
            DropTable("dbo.Agencies");
        }
    }
}
