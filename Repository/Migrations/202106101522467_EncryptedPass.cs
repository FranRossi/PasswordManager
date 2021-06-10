namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EncryptedPass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Passwords", "EncryptedPass", c => c.String(nullable: false));
            DropColumn("dbo.Passwords", "Pass");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Passwords", "Pass", c => c.String(nullable: false));
            DropColumn("dbo.Passwords", "EncryptedPass");
        }
    }
}
