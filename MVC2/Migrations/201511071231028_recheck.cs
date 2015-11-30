namespace MVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recheck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Department_DepartmentId", c => c.Int());
            CreateIndex("dbo.Departments", "Department_DepartmentId");
            AddForeignKey("dbo.Departments", "Department_DepartmentId", "dbo.Departments", "DepartmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Departments", new[] { "Department_DepartmentId" });
            DropColumn("dbo.Departments", "Department_DepartmentId");
        }
    }
}
