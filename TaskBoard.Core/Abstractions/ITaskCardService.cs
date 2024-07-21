namespace TaskBoard.Core.Abstractions
{
    public interface ITaskCardService<TCardResponse, TCardRequest> 
        where TCardResponse : class
        where TCardRequest : class
    {
        Task Create(TCardRequest request);
        Task Delete(int id);
        Task<IEnumerable<TCardResponse>> GetAllTaskCards();
        Task<TCardResponse> GetById(int id);
        Task Update(int id, TCardRequest request);
    }
}
