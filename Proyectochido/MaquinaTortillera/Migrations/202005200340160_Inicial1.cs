namespace MaquinaTortillera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Sabor", c => c.String(nullable: false));
            AddColumn("dbo.Products", "Kilos", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "MasaU", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Estado", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Estado");
            DropColumn("dbo.Products", "MasaU");
            DropColumn("dbo.Products", "Kilos");
            DropColumn("dbo.Products", "Sabor");
        }
    }
}
