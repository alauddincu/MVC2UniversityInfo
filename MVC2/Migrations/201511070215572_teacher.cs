namespace MVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        ContactNo = c.String(nullable: false),
                        Credit = c.Double(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.DesignationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "DesignationId" });
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Designations");
        }
    }
}
