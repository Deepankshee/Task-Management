using AutoMapper;
using TaskManagement.API.Models;

namespace TaskManagement.API;

public class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<AddTaskRequest, Domain.Entity.Task>();
    }
}