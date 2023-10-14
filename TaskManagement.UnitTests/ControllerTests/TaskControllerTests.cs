using System.Net;
using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TaskManagement.API.Controller;
using TaskManagement.API.Models;
using TaskManagement.Application.Services.Interfaces;

namespace TaskManagement.UnitTests.ControllerTests;

public class TaskControllerTests
{
    private readonly Mock<ITaskService> _mockTaskService;
    private readonly Mock<IMapper> _mapper;

    public TaskControllerTests()
    {
        _mockTaskService = new Mock<ITaskService>();
        _mapper = new Mock<IMapper>();
    }
    
    [Fact]
    public void ShouldAddTaskWithValidRequest()
    {
        TaskController taskController = new TaskController(_mockTaskService.Object,_mapper.Object);
        AddTaskRequest addTaskRequest = new AddTaskRequest("add user", "add user with details", DateTime.Now);

        var response = taskController.Add(addTaskRequest) as OkObjectResult;

        response?.StatusCode.Should().Be((int)HttpStatusCode.OK);
    }
}