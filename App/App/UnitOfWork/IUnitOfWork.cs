

public interface IUnitOfWork
{
    ITraineeManager TMngr { get; }
    ICourseManager CMngr { get; }
    int SaveChanges();
}