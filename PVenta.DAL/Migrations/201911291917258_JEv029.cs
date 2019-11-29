namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv029 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfigSistemas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicio = c.DateTime(nullable: false),
                        NombreNeg = c.String(nullable: false, maxLength: 50, unicode: false),
                        NombreComercial = c.String(maxLength: 80, unicode: false),
                        RNC = c.String(maxLength: 30),
                        Telefono = c.String(maxLength: 20),
                        Direccion = c.String(maxLength: 150),
                        RelacionID = c.String(maxLength: 50, unicode: false),
                        CalcITBIS = c.Boolean(nullable: false),
                        PorcITBIS = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ComprobanteFiscal = c.String(maxLength: 50),
                        NumComprobanteFiscal = c.Int(nullable: false),
                        MensajeOrden = c.String(maxLength: 150),
                        MensajeFactura = c.String(maxLength: 150),
                        ImprimeComandaAuto = c.Boolean(nullable: false),
                        ImprimeOrdenAuto = c.Boolean(nullable: false),
                        ImprimeFacturaAuto = c.Boolean(nullable: false),
                        CodigoSegInactivar = c.String(),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InfoDigitals", t => t.RelacionID)
                .Index(t => t.RelacionID);
            
            CreateTable(
                "dbo.InfoDigitals",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        IDRelacion = c.String(maxLength: 50, unicode: false),
                        TypeInfoID = c.String(maxLength: 50, unicode: false),
                        Descripcion = c.String(maxLength: 50),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypeInfos", t => t.TypeInfoID)
                .Index(t => t.TypeInfoID);
            
            CreateTable(
                "dbo.TypeInfos",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(maxLength: 50, unicode: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.CuadreDetails", "CuadreHID");
            AddForeignKey("dbo.CuadreDetails", "CuadreHID", "dbo.CuadreHeaders", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuadreDetails", "CuadreHID", "dbo.CuadreHeaders");
            DropForeignKey("dbo.ConfigSistemas", "RelacionID", "dbo.InfoDigitals");
            DropForeignKey("dbo.InfoDigitals", "TypeInfoID", "dbo.TypeInfos");
            DropIndex("dbo.CuadreDetails", new[] { "CuadreHID" });
            DropIndex("dbo.InfoDigitals", new[] { "TypeInfoID" });
            DropIndex("dbo.ConfigSistemas", new[] { "RelacionID" });
            DropTable("dbo.TypeInfos");
            DropTable("dbo.InfoDigitals");
            DropTable("dbo.ConfigSistemas");
        }
    }
}
