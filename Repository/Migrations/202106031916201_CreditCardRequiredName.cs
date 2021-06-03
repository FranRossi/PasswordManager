namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditCardRequiredName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CreditCards", "Name", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CreditCards", "Name", c => c.String(maxLength: 25));
        }
    }
}
