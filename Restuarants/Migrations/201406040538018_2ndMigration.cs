namespace Restuarants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2ndMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restuarants", "Img", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restuarants", "Img", c => c.String());
        }
    }
}
