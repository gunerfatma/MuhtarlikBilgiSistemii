namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class context : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hizmetlers",
                c => new
                    {
                        HizmetId = c.Int(nullable: false, identity: true),
                        MuhtarId = c.Int(nullable: false),
                        Baslik = c.String(),
                        Aciklama = c.String(nullable: false),
                        Durum = c.String(nullable: false),
                        Maliyet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HizmetTakibi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.HizmetId)
                .ForeignKey("dbo.Muhtars", t => t.MuhtarId, cascadeDelete: true)
                .Index(t => t.MuhtarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hizmetlers", "MuhtarId", "dbo.Muhtars");
            DropIndex("dbo.Hizmetlers", new[] { "MuhtarId" });
            DropTable("dbo.Hizmetlers");
        }
    }
}
