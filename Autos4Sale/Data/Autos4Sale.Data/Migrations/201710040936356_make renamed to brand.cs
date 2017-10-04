namespace Autos4Sale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makerenamedtobrand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarOffers", "Brand", c => c.String());
            DropColumn("dbo.CarOffers", "Make");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CarOffers", "Make", c => c.String());
            DropColumn("dbo.CarOffers", "Brand");
        }
    }
}
