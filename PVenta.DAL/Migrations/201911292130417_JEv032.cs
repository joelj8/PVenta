namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv032 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TypeInformaciones", "Orden", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TypeInformaciones", "Orden");
        }
    }
}
