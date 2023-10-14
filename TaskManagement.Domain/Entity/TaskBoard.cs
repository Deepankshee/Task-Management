using TaskManagement.Application;

namespace TaskManagement.Domain.Entity;

public class TaskBoard
{
    private List<Task> Tasks { get; } = new();
    
    public void AddTask(Task task)
    {
        if (Tasks.Any(x => x.Title == task.Title))
            throw new DuplicateTitleException("Title should be unique");
        Tasks.Add(task);
    }

    public Task? GetTaskById(Guid id)
    {
        return Tasks.FirstOrDefault(x => x.Id == id);
    }
    
}