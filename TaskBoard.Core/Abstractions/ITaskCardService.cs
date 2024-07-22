namespace TaskBoard.Core.Abstractions
{
    public interface ITaskCardService<TCardResponse, TCardRequest> 
        where TCardResponse : class
        where TCardRequest : class
    {
        Task Create(TCardRequest request);
        Task<Guid> Delete(Guid id);
        Task<IEnumerable<TCardResponse>> GetAllTaskCards();
        Task<TCardResponse> GetById(Guid id);
        Task<Guid> Update(Guid id, TCardRequest request);
    }
}
