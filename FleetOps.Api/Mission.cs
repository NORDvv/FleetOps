/*public struct Location
{
    public double x;
    public double y;
    public double z;

    public void set(double x1, double y1, double z1)
    {
        x = x1;
        y = y1;
        z = z1;
    }
}

public enum StatusModes
{
    OnStandBy,
    InProgress,
    Awaiting,
    Paused,
    Failed,
    Completed,
}*/

public enum MissionStatus
{
    Pending,
    Running,
    Completed,
    Failed,
}

// This is a domain object
public class Mission
{
    public int Id {get; set;}
    //public string? Type {get; set;}
    //public Location Target {get; set;}
    //public MissionStatus Status {get; set;}
    public MissionStatus Status {get; set;}
    public string? Target {get; set;}
    public DateTime CreatedAt {get; set;}
}