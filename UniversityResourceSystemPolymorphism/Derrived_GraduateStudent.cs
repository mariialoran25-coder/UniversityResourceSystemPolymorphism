namespace UniversityResourceSystemPolymorphism;

public class Derrived_GraduateStudent : Derrived_UndergraduateStudent
{
    public Derrived_GraduateStudent(string name, string id) : base(name, id){}

    public override void  PerformDuties()  // Activate ункція яку має кожен юніверсіть мембер 
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
        Console.WriteLine("Lecture delivered");
    }
}