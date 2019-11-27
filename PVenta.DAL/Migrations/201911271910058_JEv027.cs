namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv027 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderHeaders", "NumOrden", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderHeaders", "NumOrden", c => c.Int(nullable: false));
        }
    }
}
