namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mahalle2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mahalles", "Baslik2", c => c.String(maxLength:50));
            AddColumn("dbo.Mahalles", "Durum2", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
           
        }
    }
}
