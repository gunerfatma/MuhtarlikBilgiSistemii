namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HizmetEkleme2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hizmetlers", "Durum", c => c.String(nullable: false, maxLength:100));
            CreateIndex("dbo.Hizmetlers", "Durum");

        }

        public override void Down()
        {
        }
    }
}
