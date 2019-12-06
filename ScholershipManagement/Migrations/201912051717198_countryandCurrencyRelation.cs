namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countryandCurrencyRelation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "CurrencyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Countries", "CurrencyId");
            AddForeignKey("dbo.Countries", "CurrencyId", "dbo.Currencies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Countries", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.Countries", new[] { "CurrencyId" });
            AlterColumn("dbo.Countries", "CurrencyId", c => c.Int());
        }
    }
}
