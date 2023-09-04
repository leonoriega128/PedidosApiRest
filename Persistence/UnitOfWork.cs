using Persistence.Contexts;
using Persistence.Interfaces;
using Persistence.Repository;

namespace Persistence
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICourseRepository Courses { get; private set; }
        public IContractCRepository ContractCs { get; private set; }
        public IDressItemRepository DressItems { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            ContractCs = new ContractCRepository(_context);
            DressItems = new DressItemRepository(_context);
        }
        public async Task<int> CompletedAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}