namespace SimpleCRUD2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chore", "DayID", "dbo.Day");
            DropForeignKey("dbo.Chore", "PersonID", "dbo.Person");
            DropIndex("dbo.Chore", new[] { "DayID" });
            DropIndex("dbo.Chore", new[] { "PersonID" });
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Chore = c.String(),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.TaskID);
            
            DropTable("dbo.Chore");
            DropTable("dbo.Day");
            DropTable("dbo.Person");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Day",
                c => new
                    {
                        DayID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DayID);
            
            CreateTable(
                "dbo.Chore",
                c => new
                    {
                        ChoreID = c.Int(nullable: false, identity: true),
                        DayID = c.Int(nullable: false),
                        PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.ChoreID);
            
            DropTable("dbo.Task");
            CreateIndex("dbo.Chore", "PersonID");
            CreateIndex("dbo.Chore", "DayID");
            AddForeignKey("dbo.Chore", "PersonID", "dbo.Person", "PersonID");
            AddForeignKey("dbo.Chore", "DayID", "dbo.Day", "DayID", cascadeDelete: true);
        }
    }
}
