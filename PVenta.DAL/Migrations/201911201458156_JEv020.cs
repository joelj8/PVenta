namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv020 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ErrorList", "esError", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ErrorList", "esError");
        }
    }
}
