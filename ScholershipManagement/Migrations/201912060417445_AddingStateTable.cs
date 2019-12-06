namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingStateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Code = c.String(maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        Population = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
            DropIndex("dbo.States", new[] { "CountryId" });
            DropTable("dbo.States");
        }
    }
}
