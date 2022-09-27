namespace ConDisceplines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Disceplines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameDiscepline = c.String(),
                        Hours = c.Int(nullable: false),
                        Control = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Disceplines");
        }
    }
}
