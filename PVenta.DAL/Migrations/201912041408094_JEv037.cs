namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv037 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "permiteAdicional", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productos", "permiteAdicional");
        }
    }
}
