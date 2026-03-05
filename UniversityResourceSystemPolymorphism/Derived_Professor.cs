namespace UniversityResourceSystemPolymorphism;

public class Derived_Professor : UniversityMember
{
    public Derived_Professor(string name, string id) : base(name, id){}
    
    public override void  PerformDuties()  // Activate ункція яку має кожен юніверсіть мембер 
    {
        base.PerformDuties();
        Console.WriteLine("Lecture delivered");
    }
}