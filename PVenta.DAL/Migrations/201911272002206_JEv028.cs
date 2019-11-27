namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv028 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaHeaders", "NumFactura", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FacturaHeaders", "NumFactura");
        }
    }
}
