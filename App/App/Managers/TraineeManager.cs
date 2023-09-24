

using Microsoft.EntityFrameworkCore;

public class TraineeManager : Manager<Trainee>, ITraineeManager
{
    public TraineeManager(DbSet<Trainee> set) : base(set)
    {
    }
    public void GetExam()
    {
        throw new System.NotImplementedException();
    }
}
