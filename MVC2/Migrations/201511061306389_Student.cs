namespace MVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            AlterColumn("dbo.Departments", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Address", c => c.String());
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.Departments", "Code", c => c.String());
            DropTable("dbo.Students");
        }
    }
}
