namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWardable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnionPorisods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Code = c.String(maxLength: 50),
                        Population = c.Int(),
                        UpazilaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Upazilas", t => t.UpazilaId, cascadeDelete: true)
                .Index(t => t.UpazilaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UnionPorisods", "UpazilaId", "dbo.Upazilas");
            DropIndex("dbo.UnionPorisods", new[] { "UpazilaId" });
            DropTable("dbo.UnionPorisods");
        }
    }
}
