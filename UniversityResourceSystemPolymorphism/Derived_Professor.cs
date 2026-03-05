namespace UniversityResourceSystemPolymorphism;

public class Derived_Professor : UniversityMember
{
    public Derived_Professor(string name, string id) : base(name, id){}
    
    public override void  PerformDuties()  // Activate ункція яку має кожен юніверсіть мембер 
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
        Console.WriteLine( $"Lecture {Name} delivered");
    }

    public void ConductResearch(string topic)
    {
        Console.WriteLine( $"Lecture {Name} research for {topic}");
    }
}