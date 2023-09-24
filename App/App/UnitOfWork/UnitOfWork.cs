
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;

public class UnitOfWork : IUnitOfWork
{
    IStorage storage;
    public UnitOfWork(IStorage storage)
    {
        this.storage = storage;
    }
    private ITraineeManager tMngr;
    private ICourseManager cMngr; 
    public ITraineeManager TMngr
    {
        get
        {
            if(tMngr == null)
                tMngr = new TraineeManager(storage.Trainees);
            return tMngr;
        }
    }
    public ICourseManager CMngr
    {
        get
        {
            if (cMngr == null)
                cMngr = new CourseManager(storage.Courses);
            return cMngr;
        }
    }
    public int SaveChanges()
    {
        return storage.SaveChanges();
    }
}