namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv023 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaDetails", "Orden", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetails", "Orden", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "Orden");
            DropColumn("dbo.FacturaDetails", "Orden");
        }
    }
}
