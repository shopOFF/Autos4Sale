namespace Autos4Sale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarOffers", "Brand", c => c.String(maxLength: 50));
            AlterColumn("dbo.CarOffers", "Model", c => c.String(maxLength: 50));
            AlterColumn("dbo.CarOffers", "Description", c => c.String(maxLength: 50));
            AlterColumn("dbo.CarOffers", "SellersCurrentPhone", c => c.String(maxLength: 50));
            AlterColumn("dbo.CarOffers", "Location", c => c.String(maxLength: 150));
            AlterColumn("dbo.Images", "ImageUrl", c => c.String(maxLength: 550));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Images", "ImageUrl", c => c.String());
            AlterColumn("dbo.CarOffers", "Location", c => c.String());
            AlterColumn("dbo.CarOffers", "SellersCurrentPhone", c => c.String());
            AlterColumn("dbo.CarOffers", "Description", c => c.String());
            AlterColumn("dbo.CarOffers", "Model", c => c.String());
            AlterColumn("dbo.CarOffers", "Brand", c => c.String());
        }
    }
}
