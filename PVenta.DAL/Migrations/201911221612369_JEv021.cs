namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mesas", "Orden", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mesas", "Orden");
        }
    }
}
