using Microsoft.EntityFrameworkCore;
using TaskBoard.DAL.Entities;


namespace TaskBoard.DAL
{
    public class TaskBoardDbContext : DbContext
    {
        public TaskBoardDbContext(DbContextOptions<TaskBoardDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        public DbSet<TaskCardEntity> Tasks { get; set; }
    }
}
