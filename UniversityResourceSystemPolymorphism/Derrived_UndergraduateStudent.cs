namespace UniversityResourceSystemPolymorphism;

public class Derrived_UndergraduateStudent : UniversityMember
{
    public Derrived_UndergraduateStudent(string name, string id) : base(name, id){}
    
    public override void  PerformDuties()  // Activate ункція яку має кожен юніверсіть мембер 
    {
        Isworking = true;
        Console.WriteLine("Lab work completed");
    }
}