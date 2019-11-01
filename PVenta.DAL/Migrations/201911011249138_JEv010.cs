namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv010 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogEventos", "TipoEvento", c => c.String(maxLength: 50, unicode: false));
            DropColumn("dbo.LogEventos", "Evento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogEventos", "Evento", c => c.String(maxLength: 3000, unicode: false));
            DropColumn("dbo.LogEventos", "TipoEvento");
        }
    }
}
