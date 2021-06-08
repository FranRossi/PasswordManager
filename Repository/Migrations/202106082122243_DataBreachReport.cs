namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataBreachReport : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DataBreachReports", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.DataBreachReportEntries", "DataBreachReport_Id", "dbo.DataBreachReports");
            DropForeignKey("dbo.DataBreachReportItems", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.DataBreachReportItems", "DataBreachReport_Id", "dbo.DataBreachReports");
            DropIndex("dbo.DataBreachReportItems", new[] { "Item_Id" });
            DropIndex("dbo.DataBreachReportItems", new[] { "DataBreachReport_Id" });
            DropIndex("dbo.DataBreachReportEntries", new[] { "DataBreachReport_Id" });
            DropIndex("dbo.DataBreachReports", new[] { "User_MasterName" });
            DropTable("dbo.DataBreachReportItems");
            DropTable("dbo.DataBreachReportEntries");
            DropTable("dbo.DataBreachReports");
        }
    }
}
