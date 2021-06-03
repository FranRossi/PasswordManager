namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreditCard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 25),
                        Type = c.String(nullable: false, maxLength: 25),
                        Number = c.String(nullable: false, maxLength: 16),
                        SecureCode = c.String(nullable: false, maxLength: 3),
                        ExpirationDate = c.String(nullable: false, maxLength: 5),
                        Notes = c.String(),
                        Category_Id = c.Int(),
                        User_MasterName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.User_MasterName, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.User_MasterName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.CreditCards", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CreditCards", new[] { "User_MasterName" });
            DropIndex("dbo.CreditCards", new[] { "Category_Id" });
            DropTable("dbo.CreditCards");
        }
    }
}
