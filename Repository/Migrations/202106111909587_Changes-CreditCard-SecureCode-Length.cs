namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesCreditCardSecureCodeLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CreditCards", "SecureCode", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CreditCards", "SecureCode", c => c.String(nullable: false, maxLength: 3));
        }
    }
}
