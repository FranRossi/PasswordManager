namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleanMigrationMerge : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                        User_MasterName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_MasterName, cascadeDelete: true)
                .Index(t => t.User_MasterName);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        MasterName = c.String(nullable: false, maxLength: 25),
                        MasterPass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MasterName);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Notes = c.String(maxLength: 250),
                        Category_Id = c.Int(nullable: false),
                        User_MasterName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.User_MasterName, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.User_MasterName);
            
            CreateTable(
                "dbo.DataBreachReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        User_MasterName = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_MasterName)
                .Index(t => t.User_MasterName);
            
            CreateTable(
                "dbo.DataBreachReportEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        DataBreachReport_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataBreachReports", t => t.DataBreachReport_Id, cascadeDelete: true)
                .Index(t => t.DataBreachReport_Id);
            
            CreateTable(
                "dbo.SharedPasswordUser",
                c => new
                    {
                        PasswordId = c.Int(nullable: false),
                        UserSharedWithName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => new { t.PasswordId, t.UserSharedWithName })
                .ForeignKey("dbo.Passwords", t => t.PasswordId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserSharedWithName, cascadeDelete: true)
                .Index(t => t.PasswordId)
                .Index(t => t.UserSharedWithName);
            
            CreateTable(
                "dbo.DataBreachReportItems",
                c => new
                    {
                        DataBreachReport_Id = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DataBreachReport_Id, t.Item_Id })
                .ForeignKey("dbo.DataBreachReports", t => t.DataBreachReport_Id, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.DataBreachReport_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 25),
                        Type = c.String(nullable: false, maxLength: 25),
                        Number = c.String(nullable: false, maxLength: 16),
                        SecureCode = c.String(nullable: false, maxLength: 3),
                        ExpirationDate = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PasswordStrength = c.Int(nullable: false),
                        Site = c.String(nullable: false, maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                        Pass = c.String(nullable: false),
                        LastModification = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passwords", "Id", "dbo.Items");
            DropForeignKey("dbo.CreditCards", "Id", "dbo.Items");
            DropForeignKey("dbo.DataBreachReports", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.DataBreachReportEntries", "DataBreachReport_Id", "dbo.DataBreachReports");
            DropForeignKey("dbo.DataBreachReportItems", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.DataBreachReportItems", "DataBreachReport_Id", "dbo.DataBreachReports");
            DropForeignKey("dbo.SharedPasswordUser", "UserSharedWithName", "dbo.Users");
            DropForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords");
            DropForeignKey("dbo.Items", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "User_MasterName", "dbo.Users");
            DropIndex("dbo.Passwords", new[] { "Id" });
            DropIndex("dbo.CreditCards", new[] { "Id" });
            DropIndex("dbo.DataBreachReportItems", new[] { "Item_Id" });
            DropIndex("dbo.DataBreachReportItems", new[] { "DataBreachReport_Id" });
            DropIndex("dbo.SharedPasswordUser", new[] { "UserSharedWithName" });
            DropIndex("dbo.SharedPasswordUser", new[] { "PasswordId" });
            DropIndex("dbo.DataBreachReportEntries", new[] { "DataBreachReport_Id" });
            DropIndex("dbo.DataBreachReports", new[] { "User_MasterName" });
            DropIndex("dbo.Items", new[] { "User_MasterName" });
            DropIndex("dbo.Items", new[] { "Category_Id" });
            DropIndex("dbo.Categories", new[] { "User_MasterName" });
            DropTable("dbo.Passwords");
            DropTable("dbo.CreditCards");
            DropTable("dbo.DataBreachReportItems");
            DropTable("dbo.SharedPasswordUser");
            DropTable("dbo.DataBreachReportEntries");
            DropTable("dbo.DataBreachReports");
            DropTable("dbo.Items");
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
        }
    }
}
