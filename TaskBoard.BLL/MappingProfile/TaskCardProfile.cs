using TaskBoard.Core.Models;
using TaskBoard.DAL.Entities;
using AutoMapper;
using TaskBoard.BLL.DTO;

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
            CreateMap<TaskCardDto, TaskCardEntity>()
                .ReverseMap();
        }
    }

}
