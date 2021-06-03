namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsernameRename : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Name", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "Name" });
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.Categories", "User_Username", c => c.String(maxLength: 25));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AddPrimaryKey("dbo.Users", "Username");
            CreateIndex("dbo.Categories", "User_Username");
            AddForeignKey("dbo.Categories", "User_Username", "dbo.Users", "Username");
            DropColumn("dbo.Users", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 25));
            DropForeignKey("dbo.Categories", "User_Username", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "User_Username" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 25));
            DropColumn("dbo.Categories", "User_Username");
            DropColumn("dbo.Users", "Username");
            AddPrimaryKey("dbo.Users", "Name");
            CreateIndex("dbo.Categories", "Name");
            AddForeignKey("dbo.Categories", "Name", "dbo.Users", "Name");
        }
    }
}
