namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv016 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormaPagos",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 30, unicode: false),
                        MonedaID = c.String(maxLength: 50, unicode: false),
                        Inactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Monedas", t => t.MonedaID)
                .Index(t => t.MonedaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormaPagos", "MonedaID", "dbo.Monedas");
            DropIndex("dbo.FormaPagos", new[] { "MonedaID" });
            DropTable("dbo.FormaPagos");
        }
    }
}
