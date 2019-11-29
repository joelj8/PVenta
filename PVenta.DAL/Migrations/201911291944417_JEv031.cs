namespace PVenta.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JEv031 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TypeInfos", newName: "TypeInformaciones");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TypeInformaciones", newName: "TypeInfos");
        }
    }
}
