

using Microsoft.EntityFrameworkCore;

public class CourseManager : Manager<Course>, ICourseManager
{
    public CourseManager(DbSet<Course> set): base(set)
    { }
}