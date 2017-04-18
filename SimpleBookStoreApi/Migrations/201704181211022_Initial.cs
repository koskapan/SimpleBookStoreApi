namespace SimpleBookStoreApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.books",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        title = c.String(),
                        description = c.String(),
                        author = c.String(),
                        publication_year = c.Int(nullable: false),
                        image_url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.books");
        }
    }
}
