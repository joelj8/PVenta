namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv008 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEventos", "msgError", c => c.String(maxLength: 3000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogEventos", "msgError");
        }
    }
}
