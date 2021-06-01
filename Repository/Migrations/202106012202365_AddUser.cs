namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Name = c.String(nullable: false, maxLength: 25),
                    MasterPass = c.String(nullable: false, maxLength: 25),
                })
                .PrimaryKey(t => t.Name);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 25),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Name)
                .Index(t => t.Name);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Name", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "Name" });
            DropTable("dbo.Categories");
            DropTable("dbo.Users");
        }
    }
}
