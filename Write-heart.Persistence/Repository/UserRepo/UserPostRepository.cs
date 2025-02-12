using Microsoft.EntityFrameworkCore;
using System;
using Write_heart.Persistence.Db;
using Write_Heart.Domain.Entities;

namespace Write_heart.Persistence.Repository.UserRepo
{
    public class UserPostRepository : Repository<User>, IUserPostRepository
    {
        private readonly ApplicationDbContext _context;

        public UserPostRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<UserPosts>> GetAllAsync()
        {
            return await _context.UsersPost.ToListAsync();
        }

        public async Task<UserPosts?> GetByIdAsync(int id)
        {
            return await _context.UsersPost.FindAsync(id);
        }

        public async Task AddAsync(UserPosts content)
        {
            await _context.UsersPost.AddAsync(content);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var content = await _context.UsersPost.FindAsync(id);
            if (content == null) return false;

            _context.UsersPost.Remove(content);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
