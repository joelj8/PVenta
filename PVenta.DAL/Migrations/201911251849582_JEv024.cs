namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv024 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.FacturaPayments", "FacturaHID");
            AddForeignKey("dbo.FacturaPayments", "FacturaHID", "dbo.FacturaHeaders", "ID", cascadeDelete: true);
            DropColumn("dbo.FacturaPayments", "FacturaDID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FacturaPayments", "FacturaDID", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropForeignKey("dbo.FacturaPayments", "FacturaHID", "dbo.FacturaHeaders");
            DropIndex("dbo.FacturaPayments", new[] { "FacturaHID" });
        }
    }
}
