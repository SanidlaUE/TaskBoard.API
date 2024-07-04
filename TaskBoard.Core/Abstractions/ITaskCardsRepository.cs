﻿namespace TaskBoard.Core.Abstractions
{
    public interface ITaskCardsRepository<TCardEntity> where TCardEntity : class
    {
        Task<IEnumerable<TCardEntity>> GetAll();
        Task<TCardEntity> GetById(int id);
        Task Create(TCardEntity entity);
        Task Update(TCardEntity entity);
        Task Delete(int id);

    }
}
