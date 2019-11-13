namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FormaPagos", "MonedaID", "dbo.Monedas");
            DropIndex("dbo.FormaPagos", new[] { "MonedaID" });
            AlterColumn("dbo.FormaPagos", "MonedaID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FormaPagos", "MonedaID", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.FormaPagos", "MonedaID");
            AddForeignKey("dbo.FormaPagos", "MonedaID", "dbo.Monedas", "ID");
        }
    }
}
