namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv003 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Usuarios", "RolId");
            AddForeignKey("dbo.Usuarios", "RolId", "dbo.Roles", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "RolId", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "RolId" });
        }
    }
}
