namespace TestApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vava : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        INN = c.String(nullable: false, maxLength: 128),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.INN);
            
            CreateTable(
                "dbo.Delivery",
                c => new
                    {
                        Number = c.String(nullable: false, maxLength: 128),
                        INN = c.String(nullable: false, maxLength: 128),
                        Currency = c.Int(nullable: false),
                        Sum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Number)
                .ForeignKey("dbo.Company", t => t.INN, cascadeDelete: true)
                .Index(t => t.INN);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Delivery", "INN", "dbo.Company");
            DropIndex("dbo.Delivery", new[] { "INN" });
            DropTable("dbo.Delivery");
            DropTable("dbo.Company");
        }
    }
}
