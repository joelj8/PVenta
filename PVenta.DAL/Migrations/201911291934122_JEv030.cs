namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv030 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ConfigSistemas", "RelacionID", "dbo.InfoDigitals");
            DropForeignKey("dbo.CuadreDetails", "CuadreHID", "dbo.CuadreHeaders");
            DropIndex("dbo.ConfigSistemas", new[] { "RelacionID" });
            DropIndex("dbo.CuadreDetails", new[] { "CuadreHID" });
            AlterColumn("dbo.ConfigSistemas", "RelacionID", c => c.String(maxLength: 150));
            CreateIndex("dbo.InfoDigitals", "IDRelacion");
            AddForeignKey("dbo.InfoDigitals", "IDRelacion", "dbo.ConfigSistemas", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InfoDigitals", "IDRelacion", "dbo.ConfigSistemas");
            DropIndex("dbo.InfoDigitals", new[] { "IDRelacion" });
            AlterColumn("dbo.ConfigSistemas", "RelacionID", c => c.String(maxLength: 50, unicode: false));
            CreateIndex("dbo.CuadreDetails", "CuadreHID");
            CreateIndex("dbo.ConfigSistemas", "RelacionID");
            AddForeignKey("dbo.CuadreDetails", "CuadreHID", "dbo.CuadreHeaders", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ConfigSistemas", "RelacionID", "dbo.InfoDigitals", "ID");
        }
    }
}
