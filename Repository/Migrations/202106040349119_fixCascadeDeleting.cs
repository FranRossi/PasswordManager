namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixCascadeDeleting : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Items", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords");
            DropForeignKey("dbo.SharedPasswordUser", "UserSharedWithName", "dbo.Users");
            DropIndex("dbo.Items", new[] { "User_MasterName" });
            AlterColumn("dbo.Items", "User_MasterName", c => c.String(nullable: false, maxLength: 25));
            CreateIndex("dbo.Items", "User_MasterName");
            AddForeignKey("dbo.Items", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Items", "User_MasterName", "dbo.Users", "MasterName", cascadeDelete: true);
            AddForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SharedPasswordUser", "UserSharedWithName", "dbo.Users", "MasterName", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SharedPasswordUser", "UserSharedWithName", "dbo.Users");
            DropForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords");
            DropForeignKey("dbo.Items", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.Items", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "User_MasterName" });
            AlterColumn("dbo.Items", "User_MasterName", c => c.String(maxLength: 25));
            CreateIndex("dbo.Items", "User_MasterName");
            AddForeignKey("dbo.SharedPasswordUser", "UserSharedWithName", "dbo.Users", "MasterName");
            AddForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords", "Id");
            AddForeignKey("dbo.Items", "User_MasterName", "dbo.Users", "MasterName");
            AddForeignKey("dbo.Items", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
