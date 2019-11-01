namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv009 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ErrorList",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Codigo = c.String(nullable: false, maxLength: 8000, unicode: false),
                        MsgError = c.String(nullable: false, maxLength: 3000, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.LogEventos", "ErrorListId", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.LogEventos", "ErrorListId");
            AddForeignKey("dbo.LogEventos", "ErrorListId", "dbo.ErrorList", "ID", cascadeDelete: true);
            DropColumn("dbo.LogEventos", "TipoEvento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogEventos", "TipoEvento", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropForeignKey("dbo.LogEventos", "ErrorListId", "dbo.ErrorList");
            DropIndex("dbo.LogEventos", new[] { "ErrorListId" });
            DropColumn("dbo.LogEventos", "ErrorListId");
            DropTable("dbo.ErrorList");
        }
    }
}
