using Persistence.Interfaces;

namespace Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IContractCRepository ContractCs { get; }
        IDressItemRepository DressItems { get; }
        Task<int> CompletedAsync();
    }
}