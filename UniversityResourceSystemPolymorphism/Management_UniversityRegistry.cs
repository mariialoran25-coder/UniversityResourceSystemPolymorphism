namespace UniversityResourceSystemPolymorphism;

public class Management_UniversityRegistry
{
    private List<UniversityMember> members = new List<UniversityMember>();

    public void Register(UniversityMember m) => members.Add(m);
    
    public void ExecuteAllDuties()
    {
        foreach (var member in members)
        {
            member.PerformDuties();
        }
    }

    public Management_UniversityRegistry()
    {
        members.ForEach(member => member.PerformDuties());
    }
}