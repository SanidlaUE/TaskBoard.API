using TaskBoard.Core.Models;
using TaskBoard.DAL.Entities;
using AutoMapper;
using TaskBoard.BLL.DTO;

namespace TaskBoard.DAL.Configuration
{
    public class TaskCardEntityToResponseProfile : Profile
    {
        public TaskCardEntityToResponseProfile()
        {
            CreateMap<TaskCardEntity, TaskCardResponse>()
                .ReverseMap();
        }
    }
    public class TaskCardRequestToEntityProfile : Profile
    {
        public TaskCardRequestToEntityProfile()
        {
            CreateMap<TaskCardRequest, TaskCardEntity>()
                .ReverseMap();
        }
    }

}
