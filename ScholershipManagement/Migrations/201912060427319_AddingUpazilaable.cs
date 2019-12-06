namespace ScholershipManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUpazilaable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Upazilas",
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
            
            AlterColumn("dbo.States", "Population", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Upazilas", "StateId", "dbo.States");
            DropIndex("dbo.Upazilas", new[] { "StateId" });
            AlterColumn("dbo.States", "Population", c => c.Int(nullable: false));
            DropTable("dbo.Upazilas");
        }
    }
}
