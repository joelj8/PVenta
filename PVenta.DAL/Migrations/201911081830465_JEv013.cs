namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv013 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.OrderHeaders", "MesaId");
            AddForeignKey("dbo.OrderHeaders", "MesaId", "dbo.Mesas", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderHeaders", "MesaId", "dbo.Mesas");
            DropIndex("dbo.OrderHeaders", new[] { "MesaId" });
        }
    }
}
