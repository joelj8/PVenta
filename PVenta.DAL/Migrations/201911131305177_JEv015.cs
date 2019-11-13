namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv015 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaDetails", "OrderDID", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.FacturaDetails", "FacturaHID");
            CreateIndex("dbo.FacturaDetails", "ProductoID");
            AddForeignKey("dbo.FacturaDetails", "FacturaHID", "dbo.FacturaHeaders", "ID", cascadeDelete: true);
            AddForeignKey("dbo.FacturaDetails", "ProductoID", "dbo.Productos", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaDetails", "ProductoID", "dbo.Productos");
            DropForeignKey("dbo.FacturaDetails", "FacturaHID", "dbo.FacturaHeaders");
            DropIndex("dbo.FacturaDetails", new[] { "ProductoID" });
            DropIndex("dbo.FacturaDetails", new[] { "FacturaHID" });
            DropColumn("dbo.FacturaDetails", "OrderDID");
        }
    }
}
