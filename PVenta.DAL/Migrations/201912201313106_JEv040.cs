namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv040 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormaPagos", "AceptaCambio", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormaPagos", "AceptaCambio");
        }
    }
}
