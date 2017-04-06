namespace Palliative.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        event_type = c.String(),
                        event_data = c.String(),
                        created = c.DateTime(nullable: false),
                        current = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventModels");
        }
    }
}
