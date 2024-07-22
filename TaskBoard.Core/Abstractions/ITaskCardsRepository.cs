namespace TaskBoard.Core.Abstractions
{
    public interface ITaskCardsRepository<TCardEntity> where TCardEntity : class
    {
        Task<IEnumerable<TCardEntity>> GetAll();
        Task<TCardEntity> GetById(Guid id);
        Task Create(TCardEntity entity);
        Task<Guid> UpdateTaskAsync(Guid id,TCardEntity entity);
        Task<Guid> Delete(Guid id);

    }
}
