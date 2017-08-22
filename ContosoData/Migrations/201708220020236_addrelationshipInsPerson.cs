namespace ContosoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrelationshipInsPerson : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors");
            DropForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropPrimaryKey("dbo.Instructors");
            AlterColumn("dbo.Instructors", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Instructors", "Id");
            CreateIndex("dbo.Instructors", "Id");
            AddForeignKey("dbo.Instructors", "Id", "dbo.People", "Id");
            AddForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors", "Id");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "Id", "dbo.People");
            DropIndex("dbo.Instructors", new[] { "Id" });
            DropPrimaryKey("dbo.Instructors");
            AlterColumn("dbo.Instructors", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Instructors", "Id");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructors", "Id");
            AddForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructors", "Id", cascadeDelete: true);
        }
    }
}
