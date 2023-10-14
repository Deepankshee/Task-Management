namespace TaskManagement.Domain.Entity;

public class Task
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; }
    public string Description { get; }
    public DateTime? DueDate { get; }
    
    public Task(string title, string description, DateTime? dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }
}