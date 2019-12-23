namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv041 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FacturaPayments", "MontoDevolver", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FacturaPayments", "FormaPagoId", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.FacturaPayments", "InfoPago", c => c.String());
            CreateIndex("dbo.FacturaPayments", "FormaPagoId");
            AddForeignKey("dbo.FacturaPayments", "FormaPagoId", "dbo.FormaPagos", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaPayments", "FormaPagoId", "dbo.FormaPagos");
            DropIndex("dbo.FacturaPayments", new[] { "FormaPagoId" });
            DropColumn("dbo.FacturaPayments", "InfoPago");
            DropColumn("dbo.FacturaPayments", "FormaPagoId");
            DropColumn("dbo.FacturaPayments", "MontoDevolver");
        }
    }
}
