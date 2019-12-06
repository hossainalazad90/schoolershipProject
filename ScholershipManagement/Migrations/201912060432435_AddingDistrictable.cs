namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDistrictable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Upazilas", name: "StateId", newName: "DistrictId");
            RenameIndex(table: "dbo.Upazilas", name: "IX_StateId", newName: "IX_DistrictId");
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Code = c.String(maxLength: 50),
                        Population = c.Int(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Districts", "StateId", "dbo.States");
            DropIndex("dbo.Districts", new[] { "StateId" });
            DropTable("dbo.Districts");
            RenameIndex(table: "dbo.Upazilas", name: "IX_DistrictId", newName: "IX_StateId");
            RenameColumn(table: "dbo.Upazilas", name: "DistrictId", newName: "StateId");
        }
    }
}
