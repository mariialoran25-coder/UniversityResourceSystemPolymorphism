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

    public void GetMemberStatistics()
    {
        int totalAction =0;
        foreach (var member in members)
        {
            totalAction += member.ActionCount();
        }
        Console.WriteLine(totalAction);
        
    }
}