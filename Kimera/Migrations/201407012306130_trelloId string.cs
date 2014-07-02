namespace Kimera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trelloIdstring : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Data", "TrelloId");
            AddColumn("dbo.Data", "TrelloId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data", "TrelloId");
            AddColumn("dbo.Data", "TrelloId", c => c.Int(nullable: false));
        }
    }
}
