

using System;

public class Program
{
    public static void Main()
    {
        IStorage storgae = new InMemoryStorage();
        IUnitOfWork unitOfWork = new UnitOfWork(storgae);
        ITraineeManager TMngr = unitOfWork.TMngr;
        ICourseManager CMngr = unitOfWork.CMngr;



        TMngr.Add(new Trainee { Id = 1, Name = "Hany" });
        TMngr.Add(new Trainee { Id = 2, Name = "Saja" });




        CMngr.Add(new Course { Id = 3, Name = ".NET" });


        unitOfWork.SaveChanges();





        foreach(Course c in CMngr.GetAll())
            Console.WriteLine(c.Name);


        foreach (Trainee t in TMngr.GetAll())
            Console.WriteLine(t.Name);





    }
}