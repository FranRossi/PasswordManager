namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "User_MasterName", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "User_MasterName" });
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Categories", "User_MasterName", c => c.String(nullable: false, maxLength: 25));
            CreateIndex("dbo.Categories", "User_MasterName");
            AddForeignKey("dbo.Categories", "User_MasterName", "dbo.Users", "MasterName", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "User_MasterName", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "User_MasterName" });
            AlterColumn("dbo.Categories", "User_MasterName", c => c.String(maxLength: 25));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            CreateIndex("dbo.Categories", "User_MasterName");
            AddForeignKey("dbo.Categories", "User_MasterName", "dbo.Users", "MasterName");
        }
    }
}
