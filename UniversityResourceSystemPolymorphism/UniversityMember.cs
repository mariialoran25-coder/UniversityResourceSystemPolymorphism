namespace UniversityResourceSystemPolymorphism;

public class UniversityMember
{
    private string _MemberId;
    private string Name 
    {
        get => _MemberId;
        set => _MemberId = string.IsNullOrEmpty(value) ?
            throw new Exception("Cannot be empty"): value;
    }
    
    protected List<string> ActionLog = new List<string>();  //Для відстеження виконаних обов'язків  To track performed duties

    public void Initializes(string name, string id)
    {
        Name = name;
        _MemberId = id;
    }
    public void PerformDuties()
    {
        if (ActionLog.Count == 5)
        {
            throw new Exception("You are reached a daily limit of 5 actions");
        }
    }
}