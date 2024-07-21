using Microsoft.EntityFrameworkCore;
using TaskBoard.Core.Abstractions;
using TaskBoard.DAL.Entities;

namespace TaskBoard.DAL.Repositories
{
    public class TaskCardsRepository : ITaskCardsRepository<TaskCardEntity>
    {
        private readonly TaskBoardDbContext _context;
        public TaskCardsRepository(TaskBoardDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TaskCardEntity>> GetAll()
        {
            return await _context.Tasks
                        .AsNoTracking()
                        .ToListAsync();
        }
        public async Task<TaskCardEntity> GetById(int id)
        {
            return await _context.Tasks
                        .AsNoTracking()
                        .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task Create(TaskCardEntity taskCardEntity)
        {
            await _context.Tasks.AddAsync(taskCardEntity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTaskAsync(TaskCardEntity taskCardEntity)
        {
            await _context.Tasks
                .Where(b => b.Id == taskCardEntity.Id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.Title, b => taskCardEntity.Title)
                .SetProperty(b => b.Description, b => taskCardEntity.Description)
                .SetProperty(b => b.DueDate, b => taskCardEntity.DueDate)
                .SetProperty(b => b.Priority, b => taskCardEntity.Priority)
                .SetProperty(b => b.Status, b => taskCardEntity.Status));
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            await _context.Tasks
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }
    }
}
