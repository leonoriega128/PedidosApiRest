using Domain.Entities;
using Persistence.Contexts;
using Persistence.Interfaces;

namespace Persistence.Repository
{
    public class ContractCRepository : BaseRepository<ContractC>, IContractCRepository
    {

        public ContractCRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }

}