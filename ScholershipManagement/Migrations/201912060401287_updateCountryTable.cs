namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCountryTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "ISOCode2", c => c.String());
            AddColumn("dbo.Countries", "ISOCode3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "ISOCode3");
            DropColumn("dbo.Countries", "ISOCode2");
        }
    }
}
