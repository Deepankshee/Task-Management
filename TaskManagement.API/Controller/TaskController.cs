using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.API.Models;
using TaskManagement.Application.Services.Interfaces;
using Task = TaskManagement.Domain.Entity.Task;

namespace TaskManagement.API.Controller;

[ApiController]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;
    private readonly IMapper _mapper;
    public TaskController(ITaskService taskService, IMapper mapper)
    {
        _taskService = taskService;
        _mapper = mapper;
    }
        [HttpPost]
        public IActionResult Add(AddTaskRequest taskRequest)
        {
            var taskEntity = _mapper.Map<Task>(taskRequest);
            _taskService.AddTask(taskEntity);
            return new OkObjectResult(taskRequest);
        }
}