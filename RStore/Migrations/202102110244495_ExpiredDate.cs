namespace RStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpiredDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ExpiredDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ExpiredDate");
        }
    }
}
