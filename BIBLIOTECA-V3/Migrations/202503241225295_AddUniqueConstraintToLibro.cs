namespace BIBLIOTECA_V3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniqueConstraintToLibro : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Libroes", "Titulo", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Libroes", new[] { "Titulo" });
        }
    }
}
