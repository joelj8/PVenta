namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv018 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "Referencia", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productos", "Referencia");
        }
    }
}
