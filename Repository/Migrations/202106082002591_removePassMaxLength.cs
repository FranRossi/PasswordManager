namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePassMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "MasterPass", c => c.String(nullable: false));
            AlterColumn("dbo.Passwords", "Pass", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Passwords", "Pass", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Users", "MasterPass", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
