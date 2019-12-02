namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv033 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.InfoDigitals", name: "IDRelacion", newName: "RelacionID");
            RenameIndex(table: "dbo.InfoDigitals", name: "IX_IDRelacion", newName: "IX_RelacionID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.InfoDigitals", name: "IX_RelacionID", newName: "IX_IDRelacion");
            RenameColumn(table: "dbo.InfoDigitals", name: "RelacionID", newName: "IDRelacion");
        }
    }
}
