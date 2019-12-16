namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv039 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfigSistemas", "DiasOrden", c => c.Int(nullable: false));
            AddColumn("dbo.ConfigSistemas", "DiasFactura", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConfigSistemas", "DiasFactura");
            DropColumn("dbo.ConfigSistemas", "DiasOrden");
        }
    }
}
