namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HizmetEkleme1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hizmetlers", "Durum", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
        }
    }
}
