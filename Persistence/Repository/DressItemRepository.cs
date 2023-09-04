using Domain.Entities;
using Persistence.Contexts;
using Persistence.Interfaces;

namespace Persistence.Repository
{
    public class DressItemRepository : BaseRepository<DressItem>, IDressItemRepository
    {
        public DressItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }

}