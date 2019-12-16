namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv038 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.FacturaHeaders", "MesaId");
            AddForeignKey("dbo.FacturaHeaders", "MesaId", "dbo.Mesas", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacturaHeaders", "MesaId", "dbo.Mesas");
            DropIndex("dbo.FacturaHeaders", new[] { "MesaId" });
        }
    }
}
