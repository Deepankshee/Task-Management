namespace TaskManagement.API.Models;

public class AddTaskRequest
{
    public string Title { get; }
    public string? Description { get; }
    public DateTime? DueDate { get; }
    public AddTaskRequest(string title, string description, DateTime? dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }
}