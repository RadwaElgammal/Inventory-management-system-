namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExchangePermits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreId = c.Int(nullable: false),
                        ExchangeNumber = c.String(),
                        ExchangeDate = c.DateTime(nullable: false, storeType: "date"),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ExchangePermitItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExchangePermitId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExchangePermits", t => t.ExchangePermitId)
                .ForeignKey("dbo.Products", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ExchangePermitId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.ImportPermits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreId = c.Int(nullable: false),
                        PermitNumber = c.String(),
                        PermitDate = c.DateTime(nullable: false, storeType: "date"),
                        SupplierId = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false, storeType: "date"),
                        ExpirationDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ImportPermitItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImportPermitId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ImportPermits", t => t.ImportPermitId)
                .ForeignKey("dbo.Products", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ImportPermitId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Transfers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromStoreId = c.Int(nullable: false),
                        ToStoreId = c.Int(nullable: false),
                        TransferDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.FromStoreId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.ToStoreId)
                .Index(t => t.FromStoreId)
                .Index(t => t.ToStoreId);
            
            CreateTable(
                "dbo.TransferItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransferId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Transfers", t => t.TransferId)
                .Index(t => t.TransferId)
                .Index(t => t.ItemId);
            
            AlterColumn("dbo.Employees", "Salary", c => c.Single());
            CreateIndex("dbo.Products", "StoreID");
            AddForeignKey("dbo.Products", "StoreID", "dbo.Stores", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExchangePermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ExchangePermitItems", "ItemId", "dbo.Products");
            DropForeignKey("dbo.Transfers", "ToStoreId", "dbo.Stores");
            DropForeignKey("dbo.TransferItems", "TransferId", "dbo.Transfers");
            DropForeignKey("dbo.TransferItems", "ItemId", "dbo.Products");
            DropForeignKey("dbo.Transfers", "FromStoreId", "dbo.Stores");
            DropForeignKey("dbo.Products", "StoreID", "dbo.Stores");
            DropForeignKey("dbo.ImportPermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ImportPermits", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ImportPermitItems", "ItemId", "dbo.Products");
            DropForeignKey("dbo.ImportPermitItems", "ImportPermitId", "dbo.ImportPermits");
            DropForeignKey("dbo.ExchangePermits", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ExchangePermitItems", "ExchangePermitId", "dbo.ExchangePermits");
            DropIndex("dbo.TransferItems", new[] { "ItemId" });
            DropIndex("dbo.TransferItems", new[] { "TransferId" });
            DropIndex("dbo.Transfers", new[] { "ToStoreId" });
            DropIndex("dbo.Transfers", new[] { "FromStoreId" });
            DropIndex("dbo.ImportPermitItems", new[] { "ItemId" });
            DropIndex("dbo.ImportPermitItems", new[] { "ImportPermitId" });
            DropIndex("dbo.ImportPermits", new[] { "SupplierId" });
            DropIndex("dbo.ImportPermits", new[] { "StoreId" });
            DropIndex("dbo.Products", new[] { "StoreID" });
            DropIndex("dbo.ExchangePermitItems", new[] { "ItemId" });
            DropIndex("dbo.ExchangePermitItems", new[] { "ExchangePermitId" });
            DropIndex("dbo.ExchangePermits", new[] { "SupplierId" });
            DropIndex("dbo.ExchangePermits", new[] { "StoreId" });
            AlterColumn("dbo.Employees", "Salary", c => c.Single(nullable: false));
            DropTable("dbo.TransferItems");
            DropTable("dbo.Transfers");
            DropTable("dbo.ImportPermitItems");
            DropTable("dbo.ImportPermits");
            DropTable("dbo.ExchangePermitItems");
            DropTable("dbo.ExchangePermits");
        }
    }
}
