namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CreditCards", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.CreditCards", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.Passwords", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Passwords", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords");
            DropIndex("dbo.CreditCards", new[] { "Category_Id" });
            DropIndex("dbo.CreditCards", new[] { "User_MasterName" });
            DropIndex("dbo.Passwords", new[] { "Category_Id" });
            DropIndex("dbo.Passwords", new[] { "User_MasterName" });
            DropPrimaryKey("dbo.CreditCards");
            DropPrimaryKey("dbo.Passwords");
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Notes = c.String(maxLength: 250),
                        Category_Id = c.Int(nullable: false),
                        User_MasterName = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_MasterName)
                .Index(t => t.Category_Id)
                .Index(t => t.User_MasterName);
            
            AlterColumn("dbo.CreditCards", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Passwords", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CreditCards", "Id");
            AddPrimaryKey("dbo.Passwords", "Id");
            CreateIndex("dbo.CreditCards", "Id");
            CreateIndex("dbo.Passwords", "Id");
            AddForeignKey("dbo.CreditCards", "Id", "dbo.Items", "Id");
            AddForeignKey("dbo.Passwords", "Id", "dbo.Items", "Id");
            AddForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords", "Id");
            DropColumn("dbo.CreditCards", "Notes");
            DropColumn("dbo.CreditCards", "Category_Id");
            DropColumn("dbo.CreditCards", "User_MasterName");
            DropColumn("dbo.Passwords", "Notes");
            DropColumn("dbo.Passwords", "Category_Id");
            DropColumn("dbo.Passwords", "User_MasterName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passwords", "User_MasterName", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.Passwords", "Category_Id", c => c.Int());
            AddColumn("dbo.Passwords", "Notes", c => c.String(maxLength: 250));
            AddColumn("dbo.CreditCards", "User_MasterName", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.CreditCards", "Category_Id", c => c.Int());
            AddColumn("dbo.CreditCards", "Notes", c => c.String());
            DropForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords");
            DropForeignKey("dbo.Items", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Passwords", "Id", "dbo.Items");
            DropForeignKey("dbo.CreditCards", "Id", "dbo.Items");
            DropIndex("dbo.Passwords", new[] { "Id" });
            DropIndex("dbo.CreditCards", new[] { "Id" });
            DropIndex("dbo.Items", new[] { "User_MasterName" });
            DropIndex("dbo.Items", new[] { "Category_Id" });
            DropPrimaryKey("dbo.Passwords");
            DropPrimaryKey("dbo.CreditCards");
            AlterColumn("dbo.Passwords", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CreditCards", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Items");
            AddPrimaryKey("dbo.Passwords", "Id");
            AddPrimaryKey("dbo.CreditCards", "Id");
            CreateIndex("dbo.Passwords", "User_MasterName");
            CreateIndex("dbo.Passwords", "Category_Id");
            CreateIndex("dbo.CreditCards", "User_MasterName");
            CreateIndex("dbo.CreditCards", "Category_Id");
            AddForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords", "Id");
            AddForeignKey("dbo.Passwords", "User_MasterName", "dbo.Users", "MasterName", cascadeDelete: true);
            AddForeignKey("dbo.Passwords", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.CreditCards", "User_MasterName", "dbo.Users", "MasterName", cascadeDelete: true);
            AddForeignKey("dbo.CreditCards", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
