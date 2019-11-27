namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv026 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderHeaders", "NumOrden", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderHeaders", "NumOrden");
        }
    }
}
