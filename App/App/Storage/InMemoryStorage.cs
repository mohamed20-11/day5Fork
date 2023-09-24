

using Microsoft.EntityFrameworkCore;

public class InMemoryStorage : DbContext, IStorage
{
    public DbSet<Trainee> Trainees { get; set; }
    public DbSet<Course> Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("db");
        base.OnConfiguring(optionsBuilder);
    }

}