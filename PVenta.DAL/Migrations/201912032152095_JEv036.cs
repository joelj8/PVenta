namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv036 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfigSistemas", "CalcServicio", c => c.Boolean(nullable: false));
            AddColumn("dbo.FacturaHeaders", "Servicio", c => c.Boolean(nullable: false));
            AddColumn("dbo.FacturaHeaders", "ServicioPorc", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderHeaders", "Servicio", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderHeaders", "ServicioPorc", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderHeaders", "ServicioPorc");
            DropColumn("dbo.OrderHeaders", "Servicio");
            DropColumn("dbo.FacturaHeaders", "ServicioPorc");
            DropColumn("dbo.FacturaHeaders", "Servicio");
            DropColumn("dbo.ConfigSistemas", "CalcServicio");
        }
    }
}
