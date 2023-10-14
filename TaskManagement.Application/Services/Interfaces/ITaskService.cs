namespace TaskManagement.Application.Services.Interfaces;
using Task = TaskManagement.Domain.Entity.Task;

public interface ITaskService
{
    public Guid AddTask(Task task);

    public Task GetTask(Guid id);
}