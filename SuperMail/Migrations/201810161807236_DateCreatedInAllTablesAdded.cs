namespace SuperMail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateCreatedInAllTablesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.estadoes", "tiempoCreado", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.mensajes", "tiempoCreado", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.mensajes", "tiempoCreado");
            DropColumn("dbo.estadoes", "tiempoCreado");
        }
    }
}
