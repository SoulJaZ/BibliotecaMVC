namespace BIBLIOTECA_V3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        AutorID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AutorID);
            
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        LibroID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 255),
                        AutorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LibroID)
                .ForeignKey("dbo.Autors", t => t.AutorID, cascadeDelete: true)
                .Index(t => t.AutorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libroes", "AutorID", "dbo.Autors");
            DropIndex("dbo.Libroes", new[] { "AutorID" });
            DropTable("dbo.Libroes");
            DropTable("dbo.Autors");
        }
    }
}
