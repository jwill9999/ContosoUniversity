namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.InstructorCourse", newName: "CourseInstructor");
            RenameColumn(table: "dbo.CourseInstructor", name: "Instructor_ID", newName: "InstructorID");
            RenameColumn(table: "dbo.CourseInstructor", name: "Course_CourseID", newName: "CourseID");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_Course_CourseID", newName: "IX_CourseID");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_Instructor_ID", newName: "IX_InstructorID");
            DropPrimaryKey("dbo.CourseInstructor");
            AddPrimaryKey("dbo.CourseInstructor", new[] { "CourseID", "InstructorID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CourseInstructor");
            AddPrimaryKey("dbo.CourseInstructor", new[] { "Instructor_ID", "Course_CourseID" });
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_InstructorID", newName: "IX_Instructor_ID");
            RenameIndex(table: "dbo.CourseInstructor", name: "IX_CourseID", newName: "IX_Course_CourseID");
            RenameColumn(table: "dbo.CourseInstructor", name: "CourseID", newName: "Course_CourseID");
            RenameColumn(table: "dbo.CourseInstructor", name: "InstructorID", newName: "Instructor_ID");
            RenameTable(name: "dbo.CourseInstructor", newName: "InstructorCourse");
        }
    }
}
