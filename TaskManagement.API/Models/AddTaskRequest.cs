namespace TaskManagement.API.Models;

public class AddTaskRequest
{
    private string _title;
    private string _description;
    private DateTime _dueDate;
    public AddTaskRequest(string title, string description, DateTime dueDate)
    {
        _title = title;
        _description = description;
        _dueDate = dueDate;
    }
}