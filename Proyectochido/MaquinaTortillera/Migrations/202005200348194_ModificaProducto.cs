namespace MaquinaTortillera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificaProducto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Notas", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Notas", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
