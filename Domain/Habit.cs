namespace Domain;

/// <summary>
/// Domain Object for a Habit
/// </summary>

public class Habit
{
    public string Name { get; set; }
    
    public Habit (string name)
    {
        Name = name;
    }
}