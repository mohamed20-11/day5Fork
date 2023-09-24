

using Microsoft.EntityFrameworkCore;

public interface IStorage
{
    public DbSet<Trainee>  Trainees { get; set; }
    public DbSet<Course> Courses { get; set; }
    int SaveChanges();
}