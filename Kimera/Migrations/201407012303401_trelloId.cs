namespace Kimera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trelloId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "TrelloId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data", "TrelloId");
        }
    }
}
