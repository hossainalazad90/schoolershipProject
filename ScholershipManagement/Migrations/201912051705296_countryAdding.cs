namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countryAdding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.Decimal(precision: 18, scale: 2),
                        Population = c.Int(),
                        Capital = c.String(),
                        CurrencyId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Symbol = c.String(),
                        USDollarValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Currencies");
            DropTable("dbo.Countries");
        }
    }
}
