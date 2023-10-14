using FluentAssertions;
using TaskManagement.Application;
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
        
        Guid addedId = taskService.AddTask(task);

        addedId.Should().Be(task.Id);
    }
    
    [Fact]
    public void ShouldThrowDuplicateTitleExceptionWhenTitleIsNotUnique()
    {
        TaskService taskService = new TaskService() ;
        Task firstTask = new Task("test title", "test description",DateTime.Now);
        Guid addedId = taskService.AddTask(firstTask);
        Task secondTask = new Task("test title", "test description",DateTime.Now);
        
        Action action = () => taskService.AddTask(secondTask);
        action.Should().Throw<DuplicateTitleException>().WithMessage("Title should be unique");

    }
    
    [Fact]
    public void ShouldGetTaskWithValidId()
    {
        TaskService taskService = new TaskService() ;
        Task expectedTask = new Task("test title", "test description",DateTime.Now);
        taskService.AddTask(expectedTask);

        Task actualTask =  taskService.GetTask(expectedTask.Id);
        actualTask.Should().Be(expectedTask);
    }
    
    [Fact]
    public void ShouldThrowTaskNotFoundExceptionWithInValidId()
    {
        TaskService taskService = new TaskService() ;
        Task expectedTask = new Task("test title", "test description",DateTime.Now);
        taskService.AddTask(expectedTask);

        Action action = () => taskService.GetTask(new Guid());
        action.Should().Throw<TaskNotFoundException>().WithMessage("Task not found with given Id");
    }
    
    [Fact]
    public void ShouldThrowTaskNotFoundExceptionWhenTaskListIsEmpty()
    {
        TaskService taskService = new TaskService() ;

        Action action = () => taskService.GetTask(new Guid());
        action.Should().Throw<TaskNotFoundException>().WithMessage("Task not found with given Id");
    }
}