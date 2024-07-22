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
           .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
           .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
           .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => src.DueDate))
           .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
           .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
        }
    }

}
