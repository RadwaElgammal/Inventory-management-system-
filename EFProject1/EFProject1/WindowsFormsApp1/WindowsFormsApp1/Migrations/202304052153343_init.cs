namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telephone = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Salary = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        UnitOfMeasure = c.String(),
                        StoreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ResponsiblePerson_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.ResponsiblePerson_ID)
                .Index(t => t.ResponsiblePerson_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telephone = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "ResponsiblePerson_ID", "dbo.Employees");
            DropIndex("dbo.Stores", new[] { "ResponsiblePerson_ID" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Stores");
            DropTable("dbo.Products");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
