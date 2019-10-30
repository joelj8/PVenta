namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv004 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Productos", "CategoriaId", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.Productos", "CategoriaId");
            AddForeignKey("dbo.Productos", "CategoriaId", "dbo.Categorias", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "CategoriaId" });
            AlterColumn("dbo.Productos", "CategoriaId", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
    }
}
