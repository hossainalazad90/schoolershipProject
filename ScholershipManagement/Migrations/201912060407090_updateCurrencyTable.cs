namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCurrencyTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "ISOCode2", c => c.String(maxLength: 2));
            AlterColumn("dbo.Countries", "ISOCode3", c => c.String(maxLength: 3));
            AlterColumn("dbo.Countries", "Capital", c => c.String(maxLength: 50));
            AlterColumn("dbo.Currencies", "Code", c => c.String(maxLength: 50));
            AlterColumn("dbo.Currencies", "Symbol", c => c.String(maxLength: 50));
            AlterColumn("dbo.Currencies", "USDollarValue", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "USDollarValue", c => c.Int(nullable: false));
            AlterColumn("dbo.Currencies", "Symbol", c => c.String());
            AlterColumn("dbo.Currencies", "Code", c => c.String());
            AlterColumn("dbo.Countries", "Capital", c => c.String());
            AlterColumn("dbo.Countries", "ISOCode3", c => c.String());
            AlterColumn("dbo.Countries", "ISOCode2", c => c.String());
        }
    }
}
