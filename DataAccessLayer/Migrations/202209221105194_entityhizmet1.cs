namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entityhizmet1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hizmetlers", "MuhtarAdiSoyadi", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Hizmetlers", "MuhtarGirisTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Hizmetlers", "DevamEdenPersonelAdiSoyadi", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Hizmetlers", "MaliyetTutari", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Hizmetlers", "BelediyeGirisTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Hizmetlers", "TamamlandiPersonelAdiSoyadi", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Hizmetlers", "TamamlandiBitisTarihi", c => c.DateTime(nullable: false));
            DropColumn("dbo.Hizmetlers", "HizmetTakibi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hizmetlers", "HizmetTakibi", c => c.String(nullable: false));
            DropColumn("dbo.Hizmetlers", "TamamlandiBitisTarihi");
            DropColumn("dbo.Hizmetlers", "TamamlandiPersonelAdiSoyadi");
            DropColumn("dbo.Hizmetlers", "BelediyeGirisTarihi");
            DropColumn("dbo.Hizmetlers", "MaliyetTutari");
            DropColumn("dbo.Hizmetlers", "DevamEdenPersonelAdiSoyadi");
            DropColumn("dbo.Hizmetlers", "MuhtarGirisTarihi");
            DropColumn("dbo.Hizmetlers", "MuhtarAdiSoyadi");
        }
    }
}
