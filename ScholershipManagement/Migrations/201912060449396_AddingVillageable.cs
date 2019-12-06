namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingVillageable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Villages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Code = c.String(maxLength: 50),
                        Population = c.Int(),
                        UnionPorisodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UnionPorisods", t => t.UnionPorisodId, cascadeDelete: true)
                .Index(t => t.UnionPorisodId);
            
            CreateTable(
                "dbo.Wards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Code = c.String(maxLength: 50),
                        Population = c.Int(),
                        VillageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Villages", t => t.VillageId, cascadeDelete: true)
                .Index(t => t.VillageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wards", "VillageId", "dbo.Villages");
            DropForeignKey("dbo.Villages", "UnionPorisodId", "dbo.UnionPorisods");
            DropIndex("dbo.Wards", new[] { "VillageId" });
            DropIndex("dbo.Villages", new[] { "UnionPorisodId" });
            DropTable("dbo.Wards");
            DropTable("dbo.Villages");
        }
    }
}
