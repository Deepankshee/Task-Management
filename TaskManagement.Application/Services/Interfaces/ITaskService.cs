namespace TaskManagement.Application.Services.Interfaces;
using Task = TaskManagement.Domain.Entity.Task;

public interface ITaskService
{
    public Task AddTask(Task task);
}