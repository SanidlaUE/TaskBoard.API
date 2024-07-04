using AutoMapper;
using TaskBoard.BLL.DTO;
using TaskBoard.Core.Abstractions;
using TaskBoard.DAL.Entities;


namespace TaskBoard.BLL.Services
{
    public class TaskCardService : ITaskCardService<TaskCardDto>
    {
        private readonly ITaskCardsRepository<TaskCardEntity> _taskCardsRepository;
        private readonly IMapper _mapper;
        public TaskCardService(ITaskCardsRepository<TaskCardEntity> taskCardsRepository, IMapper mapper)
        {
            _taskCardsRepository = taskCardsRepository;
            _mapper = mapper;
        }
        //промапить тут,кэширование,валидация
        public async Task<IEnumerable<TaskCardDto>> GetAllTaskCards()
        {
            var taskCardEntities = await _taskCardsRepository.GetAll();
            return _mapper.Map<IEnumerable<TaskCardDto>>(taskCardEntities);
        }
        public async Task<TaskCardDto> GetById(int id)
        {
            var taskCardEntity = await _taskCardsRepository.GetById(id);
            return _mapper.Map<TaskCardDto>(taskCardEntity);
        }
        public async Task Create(TaskCardDto taskCardDto)
        {
            var taskCardEntity = _mapper.Map<TaskCardEntity>(taskCardDto);
            await _taskCardsRepository.Create(taskCardEntity);
        }
        public async Task Update(TaskCardDto taskCardDto)
        {
            var taskCardEntity = _mapper.Map<TaskCardEntity>(taskCardDto);
            await _taskCardsRepository.Update(taskCardEntity);
        }
        public async Task Delete(int id)
        {
            await _taskCardsRepository.Delete(id);
        }
    }
}
