namespace SuperMail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.estadoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.mensajes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        contenido = c.String(),
                        destinatario = c.String(),
                        estados_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.estadoes", t => t.estados_id)
                .Index(t => t.estados_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mensajes", "estados_id", "dbo.estadoes");
            DropIndex("dbo.mensajes", new[] { "estados_id" });
            DropTable("dbo.mensajes");
            DropTable("dbo.estadoes");
        }
    }
}
