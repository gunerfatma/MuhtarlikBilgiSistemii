namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_önemlimekanlas : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.OnemliMekanlars",
                c => new
                    {
                        OnemliMekanlarId = c.Int(nullable: false, identity: true),
                        MahalleId = c.Int(nullable: false),
                        Adi = c.String(nullable: false, maxLength: 50),
                        YapiTipi = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.OnemliMekanlarId)
                .ForeignKey("dbo.Mahalles", t => t.MahalleId, cascadeDelete: true)
                .Index(t => t.MahalleId);
            
        }
        
        public override void Down()
        {
           
            DropIndex("dbo.OnemliMekanlars", new[] { "MahalleId" });
            DropTable("dbo.OnemliMekanlars");
           
        }
    }
}
