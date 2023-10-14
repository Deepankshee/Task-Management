using TaskManagement.Application.Services.Interfaces;
using TaskManagement.Domain.Entity;
using Task = TaskManagement.Domain.Entity.Task;

namespace TaskManagement.Application.Services;

public class TaskService : ITaskService
{
    private readonly TaskBoard _taskBoard = new();
    public Guid AddTask(Task task)
    {
        _taskBoard.AddTask(task);
        return task.Id;
    }
    
    public Task GetTask(Guid id)
    {
        Task? task =  _taskBoard.GetTaskById(id);
        
        if (task is null)
            throw new TaskNotFoundException("Task not found with given Id");
        return task;
    }
}