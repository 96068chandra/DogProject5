namespace DogProject5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        BreedName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DogStores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PetName = c.String(),
                        Description = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                        BreedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Breeds", t => t.BreedId, cascadeDelete: true)
                .Index(t => t.BreedId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogStores", "BreedId", "dbo.Breeds");
            DropIndex("dbo.DogStores", new[] { "BreedId" });
            DropTable("dbo.DogStores");
            DropTable("dbo.Breeds");
        }
    }
}
