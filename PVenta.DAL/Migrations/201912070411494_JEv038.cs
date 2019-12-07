namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv038 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "OrderHeader_ID", "dbo.OrderHeaders");
            DropIndex("dbo.OrderDetails", new[] { "OrderHeader_ID" });
            DropColumn("dbo.OrderDetails", "OrderHID");
            RenameColumn(table: "dbo.OrderDetails", name: "OrderHeader_ID", newName: "OrderHID");
            AlterColumn("dbo.OrderDetails", "OrderHID", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.OrderDetails", "OrderHID");
            AddForeignKey("dbo.OrderDetails", "OrderHID", "dbo.OrderHeaders", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderHID", "dbo.OrderHeaders");
            DropIndex("dbo.OrderDetails", new[] { "OrderHID" });
            AlterColumn("dbo.OrderDetails", "OrderHID", c => c.String(maxLength: 50, unicode: false));
            RenameColumn(table: "dbo.OrderDetails", name: "OrderHID", newName: "OrderHeader_ID");
            AddColumn("dbo.OrderDetails", "OrderHID", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.OrderDetails", "OrderHeader_ID");
            AddForeignKey("dbo.OrderDetails", "OrderHeader_ID", "dbo.OrderHeaders", "ID");
        }
    }
}
