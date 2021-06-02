namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassword : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "User_Username", "dbo.Users");
            RenameColumn(table: "dbo.Categories", name: "User_Username", newName: "User_MasterName");
            RenameIndex(table: "dbo.Categories", name: "IX_User_Username", newName: "IX_User_MasterName");
            DropPrimaryKey("dbo.Users");
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PasswordStrength = c.Int(nullable: false),
                        Site = c.String(nullable: false, maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                        Pass = c.String(nullable: false, maxLength: 25),
                        LastModification = c.DateTime(nullable: false),
                        Notes = c.String(maxLength: 250),
                        Category_Id = c.Int(),
                        User_MasterName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.User_MasterName, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.User_MasterName);
            
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
            
            AddColumn("dbo.Users", "MasterName", c => c.String(nullable: false, maxLength: 25));
            AddPrimaryKey("dbo.Users", "MasterName");
            AddForeignKey("dbo.Categories", "User_MasterName", "dbo.Users", "MasterName");
            DropColumn("dbo.Users", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 25));
            DropForeignKey("dbo.Categories", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.Passwords", "User_MasterName", "dbo.Users");
            DropForeignKey("dbo.SharedPasswordUser", "UserSharedWithName", "dbo.Users");
            DropForeignKey("dbo.SharedPasswordUser", "PasswordId", "dbo.Passwords");
            DropForeignKey("dbo.Passwords", "Category_Id", "dbo.Categories");
            DropIndex("dbo.SharedPasswordUser", new[] { "UserSharedWithName" });
            DropIndex("dbo.SharedPasswordUser", new[] { "PasswordId" });
            DropIndex("dbo.Passwords", new[] { "User_MasterName" });
            DropIndex("dbo.Passwords", new[] { "Category_Id" });
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "MasterName");
            DropTable("dbo.SharedPasswordUser");
            DropTable("dbo.Passwords");
            AddPrimaryKey("dbo.Users", "Username");
            RenameIndex(table: "dbo.Categories", name: "IX_User_MasterName", newName: "IX_User_Username");
            RenameColumn(table: "dbo.Categories", name: "User_MasterName", newName: "User_Username");
            AddForeignKey("dbo.Categories", "User_Username", "dbo.Users", "Username");
        }
    }
}
