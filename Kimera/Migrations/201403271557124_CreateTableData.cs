namespace Kimera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DataType = c.Int(nullable: false),
                        Json = c.String(),
                        DataParentId = c.Int(nullable: false)
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Data");
        }
    }
}
