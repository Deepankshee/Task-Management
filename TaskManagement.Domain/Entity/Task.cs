namespace TaskManagement.Domain.Entity;

public class Task
{
    private string _title;
    private string _description;
    private DateTime _dueDate;
    
    public Task(string title, string description, DateTime dueDate)
    {
        _title = title;
        _description = description;
        _dueDate = dueDate;
    }
}