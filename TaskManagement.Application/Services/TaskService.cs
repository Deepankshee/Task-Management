using TaskManagement.Application.Services.Interfaces;
using Task = TaskManagement.Domain.Entity.Task;

namespace TaskManagement.Application.Services;

public class TaskService : ITaskService
{
    private readonly List<Task> _tasks = new();
    public Task AddTask(Task task)
    {
        _tasks.Add(task);
        return task;
    }
    
    public List<Task> GetTasks()
    {
        return _tasks;
    }
}