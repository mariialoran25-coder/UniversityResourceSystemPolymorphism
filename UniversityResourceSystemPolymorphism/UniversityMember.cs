namespace UniversityResourceSystemPolymorphism;

public class UniversityMember
{
    private string _name;
    public string Name 
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ?
            throw new Exception("Cannot be empty"): value;
    }
    
    public string MemberId { get; }
    protected  bool Isworking { get; set; }
    
    protected List<string> ActionLog = new List<string>();  

    public UniversityMember(string name, string id)
    {
        Name = name;
        MemberId = id;
    }
    public virtual void PerformDuties()
    {
        Isworking = true;
        if (ActionLog.Count >= 5)
        {
            throw new Exception("You are reached a daily limit of 5 actions");
        }
    }

    public int ActionCount()
    {
        return ActionLog.Count;
    }
}