namespace SuperMail.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.mensajes", "estadoID", "dbo.estadoes");
            DropIndex("dbo.mensajes", new[] { "estadoID" });
            RenameColumn(table: "dbo.mensajes", name: "estadoID", newName: "estados_id");
            AlterColumn("dbo.mensajes", "estados_id", c => c.Int());
            CreateIndex("dbo.mensajes", "estados_id");
            AddForeignKey("dbo.mensajes", "estados_id", "dbo.estadoes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mensajes", "estados_id", "dbo.estadoes");
            DropIndex("dbo.mensajes", new[] { "estados_id" });
            AlterColumn("dbo.mensajes", "estados_id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.mensajes", name: "estados_id", newName: "estadoID");
            CreateIndex("dbo.mensajes", "estadoID");
            AddForeignKey("dbo.mensajes", "estadoID", "dbo.estadoes", "id", cascadeDelete: true);
        }
    }
}
