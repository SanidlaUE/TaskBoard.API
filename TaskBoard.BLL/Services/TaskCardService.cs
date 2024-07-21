using AutoMapper;
using TaskBoard.BLL.DTO;
using TaskBoard.Core.Abstractions;
using TaskBoard.DAL.Entities;


namespace TaskBoard.BLL.Services
{
    public class TaskCardService : ITaskCardService<TaskCardResponse,TaskCardRequest>
    {
        private readonly ITaskCardsRepository<TaskCardEntity> _taskCardsRepository;
        private readonly IMapper _mapper;
        public TaskCardService(ITaskCardsRepository<TaskCardEntity> taskCardsRepository, IMapper mapper)
        {
            _taskCardsRepository = taskCardsRepository;
            _mapper = mapper;
        }        
        public async Task<IEnumerable<TaskCardResponse>> GetAllTaskCards()
        {
            var taskCardEntities = await _taskCardsRepository.GetAll();
            return _mapper.Map<IEnumerable<TaskCardResponse>>(taskCardEntities);
        }
        public async Task<TaskCardResponse> GetById(int id)
        {
            var taskCardEntity = await _taskCardsRepository.GetById(id);
            return _mapper.Map<TaskCardResponse>(taskCardEntity);
        }
        public async Task Create(TaskCardRequest request)
        {
            var taskCardEntity = _mapper.Map<TaskCardEntity>(request);
            await _taskCardsRepository.Create(taskCardEntity);           
        }
        public async Task Update(int id,TaskCardRequest request)
        {
            var taskCard = await _taskCardsRepository.GetById(id);
            if (taskCard == null)
            {
                throw new ArgumentException("Task card not found");
            }            
            await _taskCardsRepository.UpdateTaskAsync(taskCard);
        }
        public async Task Delete(int id)
        {
            await _taskCardsRepository.Delete(id);
        }
    }
}
