namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv005 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OpcionesSist", "Codigo", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.OpcionesSist", "Descripcion", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OpcionesSist", "Descripcion", c => c.String(nullable: false, maxLength: 30, unicode: false));
            DropColumn("dbo.OpcionesSist", "Codigo");
        }
    }
}
