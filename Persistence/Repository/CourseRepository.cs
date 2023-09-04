using Domain.Entities;
using Persistence.Contexts;
using Persistence.Interfaces;

namespace Persistence.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }

}