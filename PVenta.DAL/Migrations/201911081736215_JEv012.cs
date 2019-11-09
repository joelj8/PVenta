namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv012 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderHeaders",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Fecha = c.DateTime(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 50, unicode: false),
                        MesaId = c.String(nullable: false, maxLength: 50, unicode: false),
                        ClientePrinc = c.String(maxLength: 50, unicode: false),
                        Itbis = c.Boolean(nullable: false),
                        ItbisPorc = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescMonto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescPorc = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaReg = c.DateTime(nullable: false),
                        Impreso = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        OrderHID = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductoID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImpComanda = c.Boolean(nullable: false),
                        ClientePedido = c.String(maxLength: 50, unicode: false),
                        Impreso = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.OrderHeaders", t => t.OrderHID, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.ProductoID, cascadeDelete: true)
                .Index(t => t.OrderHID)
                .Index(t => t.ProductoID);
            
            AddColumn("dbo.FacturaHeaders", "OrderHID", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.FacturaHeaders", "OrderHID");
            AddForeignKey("dbo.FacturaHeaders", "OrderHID", "dbo.OrderHeaders", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaHeaders", "OrderHID", "dbo.OrderHeaders");
            DropForeignKey("dbo.OrderDetails", "ProductoID", "dbo.Productos");
            DropForeignKey("dbo.OrderDetails", "OrderHID", "dbo.OrderHeaders");
            DropIndex("dbo.OrderDetails", new[] { "ProductoID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderHID" });
            DropIndex("dbo.FacturaHeaders", new[] { "OrderHID" });
            DropColumn("dbo.FacturaHeaders", "OrderHID");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.OrderHeaders");
        }
    }
}
