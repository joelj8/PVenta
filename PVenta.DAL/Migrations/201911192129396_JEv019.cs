namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv019 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Nombre", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
