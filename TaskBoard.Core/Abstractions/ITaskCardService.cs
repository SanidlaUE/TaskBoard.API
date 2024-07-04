namespace TaskBoard.Core.Abstractions
{    public interface ITaskCardService<TCardDto> where TCardDto : class
    {
        Task Create(TCardDto tCardDto);
        Task Delete(int id);
        Task<IEnumerable<TCardDto>> GetAllTaskCards();
        Task<TCardDto> GetById(int id);
        Task Update(TCardDto tCardDto);
    }
}
