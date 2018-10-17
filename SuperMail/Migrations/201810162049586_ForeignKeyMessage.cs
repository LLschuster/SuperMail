namespace SuperMail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyMessage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.mensajes", "estados_id", "dbo.estadoes");
            DropIndex("dbo.mensajes", new[] { "estados_id" });
            RenameColumn(table: "dbo.mensajes", name: "estados_id", newName: "estadoID");
            AlterColumn("dbo.mensajes", "estadoID", c => c.Int(nullable: false));
            CreateIndex("dbo.mensajes", "estadoID");
            AddForeignKey("dbo.mensajes", "estadoID", "dbo.estadoes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mensajes", "estadoID", "dbo.estadoes");
            DropIndex("dbo.mensajes", new[] { "estadoID" });
            AlterColumn("dbo.mensajes", "estadoID", c => c.Int());
            RenameColumn(table: "dbo.mensajes", name: "estadoID", newName: "estados_id");
            CreateIndex("dbo.mensajes", "estados_id");
            AddForeignKey("dbo.mensajes", "estados_id", "dbo.estadoes", "id");
        }
    }
}
