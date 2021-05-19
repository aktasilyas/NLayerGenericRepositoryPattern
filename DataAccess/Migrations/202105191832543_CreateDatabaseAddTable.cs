namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabaseAddTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Credit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NationalIdentity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentLessons",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Lesson_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Lesson_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Lessons", t => t.Lesson_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Lesson_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentLessons", "Lesson_Id", "dbo.Lessons");
            DropForeignKey("dbo.StudentLessons", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentLessons", new[] { "Lesson_Id" });
            DropIndex("dbo.StudentLessons", new[] { "Student_Id" });
            DropTable("dbo.StudentLessons");
            DropTable("dbo.Students");
            DropTable("dbo.Lessons");
        }
    }
}
