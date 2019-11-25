﻿namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv022 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Productos", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Productos", "Precio", c => c.String());
        }
    }
}
