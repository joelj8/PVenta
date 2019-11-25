namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv025 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FacturaHeaders", "OrderHID", "dbo.OrderHeaders");
            DropIndex("dbo.FacturaHeaders", new[] { "OrderHID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.FacturaHeaders", "OrderHID");
            AddForeignKey("dbo.FacturaHeaders", "OrderHID", "dbo.OrderHeaders", "ID");
        }
    }
}
