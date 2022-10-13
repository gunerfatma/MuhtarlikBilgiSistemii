namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class envanter1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Envanters", "Baslik1", c => c.String(maxLength:50));
            AddColumn("dbo.Envanters", "Durum1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            
        }
    }
}
