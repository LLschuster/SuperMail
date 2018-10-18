namespace SuperMail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationsMensajes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.mensajes", "contenido", c => c.String(nullable: false));
            AlterColumn("dbo.mensajes", "destinatario", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.mensajes", "destinatario", c => c.String());
            AlterColumn("dbo.mensajes", "contenido", c => c.String());
        }
    }
}
