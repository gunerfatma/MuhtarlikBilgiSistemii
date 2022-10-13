namespace DataAccessLayer.Migrations
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.Migrations;

    public partial class HizmetEklemee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Hizmetlers",
               c => new
               {
                   HizmetId = c.Int(nullable: false, identity: true),
                   MuhtarId = c.Int(nullable: false),
                   Baslik = c.String(nullable: false, maxLength: 50),
                   Aciklama = c.String(nullable: false, maxLength: 50),
                   Maliyet = c.String(nullable: false, maxLength: 50),
                   HizmetTakibi = c.String(nullable: false, maxLength: 50),
               })
               .PrimaryKey(t => t.HizmetId)
               .ForeignKey("dbo.Muhtars", t => t.MuhtarId, cascadeDelete: true)
               .Index(t => t.MuhtarId);

        }

        public override void Down()
        {
            

        }
    }
}

