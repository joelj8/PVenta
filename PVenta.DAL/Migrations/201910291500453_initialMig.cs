namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 30, unicode: false),
                        ImpComanda = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CuadreDetails",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        CuadreHID = c.String(nullable: false, maxLength: 50, unicode: false),
                        MonedaId = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Monedas", t => t.MonedaId, cascadeDelete: true)
                .Index(t => t.MonedaId);
            
            CreateTable(
                "dbo.Monedas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 30, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CuadreHeaders",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserId = c.String(nullable: false, maxLength: 50, unicode: false),
                        Fecha = c.DateTime(nullable: false),
                        MontoInicial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaReg = c.DateTime(nullable: false),
                        AdmUserId = c.String(maxLength: 50, unicode: false),
                        Cerrado = c.Boolean(nullable: false),
                        Comentario = c.String(),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FacturaDetails",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        FacturaHID = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductoID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImpComanda = c.Boolean(nullable: false),
                        ClientePedido = c.String(maxLength: 50, unicode: false),
                        Impreso = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FacturaHeaders",
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
                "dbo.FacturaPayments",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        FacturaHID = c.String(nullable: false, maxLength: 50, unicode: false),
                        FacturaDID = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserId = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaPago = c.DateTime(nullable: false),
                        MontoPago = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LogEventos",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Fecha = c.DateTime(nullable: false),
                        UserId = c.String(maxLength: 50, unicode: false),
                        TipoEvento = c.String(nullable: false, maxLength: 50, unicode: false),
                        Evento = c.String(maxLength: 3000, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mesas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 30, unicode: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OpcionesSists",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 30, unicode: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PermisosRols",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        RolId = c.String(nullable: false, maxLength: 50, unicode: false),
                        OpcionId = c.String(nullable: false, maxLength: 50, unicode: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 80, unicode: false),
                        NombreCorto = c.String(maxLength: 50, unicode: false),
                        Precio = c.String(),
                        CategoriaId = c.String(nullable: false, maxLength: 8000, unicode: false),
                        ImpComanda = c.Boolean(nullable: false),
                        esAdicional = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Modificable = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserId = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        pwduser = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 80, unicode: false),
                        RolId = c.String(nullable: false, maxLength: 50, unicode: false),
                        esCajero = c.Boolean(nullable: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuadreDetails", "MonedaId", "dbo.Monedas");
            DropIndex("dbo.CuadreDetails", new[] { "MonedaId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Rols");
            DropTable("dbo.Productos");
            DropTable("dbo.PermisosRols");
            DropTable("dbo.OpcionesSists");
            DropTable("dbo.Mesas");
            DropTable("dbo.LogEventos");
            DropTable("dbo.FacturaPayments");
            DropTable("dbo.FacturaHeaders");
            DropTable("dbo.FacturaDetails");
            DropTable("dbo.CuadreHeaders");
            DropTable("dbo.Monedas");
            DropTable("dbo.CuadreDetails");
            DropTable("dbo.Categorias");
        }
    }
}
