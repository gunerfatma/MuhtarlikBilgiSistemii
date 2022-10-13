namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_kategori : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mahalles", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Mahalles", new[] { "KategoriId" });
            DropColumn("dbo.Mahalles", "KategoriId");
            DropTable("dbo.Kategoris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            AddColumn("dbo.Mahalles", "KategoriId", c => c.Int(nullable: false));
            CreateIndex("dbo.Mahalles", "KategoriId");
            AddForeignKey("dbo.Mahalles", "KategoriId", "dbo.Kategoris", "KategoriId", cascadeDelete: true);
        }
    }
}
