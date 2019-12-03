namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv035 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConfigSistemas", "PorcServicio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConfigSistemas", "PorcServicio");
        }
    }
}
