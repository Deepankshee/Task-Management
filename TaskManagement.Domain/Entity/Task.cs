namespace TaskManagement.Domain.Entity;

public class Task
{
    public Task(string title, string description)
    {
        Title = title;
        Description = description;
    }
    public string Title { get; }
    public string Description { get;}
}