namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv006 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.PermisosRol", "RolId");
            CreateIndex("dbo.PermisosRol", "OpcionId");
            AddForeignKey("dbo.PermisosRol", "OpcionId", "dbo.OpcionesSist", "ID", cascadeDelete: true);
            AddForeignKey("dbo.PermisosRol", "RolId", "dbo.Roles", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PermisosRol", "RolId", "dbo.Roles");
            DropForeignKey("dbo.PermisosRol", "OpcionId", "dbo.OpcionesSist");
            DropIndex("dbo.PermisosRol", new[] { "OpcionId" });
            DropIndex("dbo.PermisosRol", new[] { "RolId" });
        }
    }
}
