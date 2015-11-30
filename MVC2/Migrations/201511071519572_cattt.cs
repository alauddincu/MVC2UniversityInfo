namespace MVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cattt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseAssignToTeachers",
                c => new
                    {
                        CourseAssignToTeacherId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseAssignToTeacherId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.DepartmentId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseAssignToTeachers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.CourseAssignToTeachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.CourseAssignToTeachers", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseAssignToTeachers", new[] { "TeacherId" });
            DropIndex("dbo.CourseAssignToTeachers", new[] { "DepartmentId" });
            DropIndex("dbo.CourseAssignToTeachers", new[] { "CourseId" });
            DropTable("dbo.CourseAssignToTeachers");
        }
    }
}
