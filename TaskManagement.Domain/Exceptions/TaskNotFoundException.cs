namespace TaskManagement.Application;

public class TaskNotFoundException : Exception
{
    public TaskNotFoundException(string message) : base(message) {
    }
}