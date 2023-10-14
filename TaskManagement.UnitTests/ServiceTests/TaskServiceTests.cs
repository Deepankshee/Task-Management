using FluentAssertions;
using TaskManagement.Application.Services;
using Task = TaskManagement.Domain.Entity.Task;

namespace TaskManagement.UnitTests.ServiceTests;

public class TaskServiceTests
{
    [Fact]
    public void ShouldAddTaskWithValidData()
    {
        TaskService taskService = new TaskService() ;
        Task task = new Task("test title", "test description",DateTime.Now);
        
        taskService.AddTask(task);

        taskService.GetTasks().Should().Contain(task);
    }
}