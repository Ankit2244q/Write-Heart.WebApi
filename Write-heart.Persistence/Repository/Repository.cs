using Microsoft.EntityFrameworkCore;
using Write_heart.Persistence.Db;

namespace Write_heart.Persistence.Repository
{
    public class Repository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)  // Ensure this constructor exists
        {
            _context = context;
        }
    }

}
