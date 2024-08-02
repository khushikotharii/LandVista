namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LandDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LandSize = c.Double(nullable: false),
                        Location = c.String(nullable: false, maxLength: 100),
                        OwnerHistory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Predictions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LandID = c.Int(nullable: false),
                        PredictionResult = c.String(nullable: false, maxLength: 50),
                        Probability = c.Double(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LandDatas", t => t.LandID, cascadeDelete: true)
                .Index(t => t.LandID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Role = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.companies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Predictions", "LandID", "dbo.LandDatas");
            DropIndex("dbo.Predictions", new[] { "LandID" });
            DropTable("dbo.Users");
            DropTable("dbo.Predictions");
            DropTable("dbo.LandDatas");
        }
    }
}
