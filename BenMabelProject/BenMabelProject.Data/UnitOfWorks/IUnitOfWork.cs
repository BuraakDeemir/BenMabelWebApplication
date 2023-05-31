using BenMabelProject.Data.Repositories.Absraction;

namespace BenMabelProject.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;

        Task<int> SaveAsync();

        int Save();
    }
}
