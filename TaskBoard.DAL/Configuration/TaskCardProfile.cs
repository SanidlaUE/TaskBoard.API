using TaskBoard.Core.Models;
using TaskBoard.DAL.Entities;
using AutoMapper;

namespace TaskBoard.DAL.Configuration
{
    public class TaskCardToDtoProfile : Profile
    {
        public TaskCardToDtoProfile()
        {
            CreateMap<TaskCard, TaskCardEntity>()
                .ReverseMap();
        }
    }
    public class TaskCardToEntityProfile : Profile
    {
        public TaskCardToEntityProfile()
        {
            CreateMap<TaskCard, TaskCardEntity>()
                .ReverseMap();
        }
    }
    public class TaskCardDtoToEntityProfile : Profile
    {
        public TaskCardDtoToEntityProfile()
        {
            CreateMap<TaskCardEntity, TaskCardEntity>()
                .ReverseMap();
        }
    }
}
