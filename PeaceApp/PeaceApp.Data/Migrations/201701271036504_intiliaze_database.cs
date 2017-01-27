namespace PeaceApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiliaze_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false, maxLength: 50),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursesInStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        CreatedDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CoursesInStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.CoursesInStudents", "CourseId", "dbo.Courses");
            DropIndex("dbo.CoursesInStudents", new[] { "CourseId" });
            DropIndex("dbo.CoursesInStudents", new[] { "StudentId" });
            DropTable("dbo.Students");
            DropTable("dbo.CoursesInStudents");
            DropTable("dbo.Courses");
        }
    }
}
