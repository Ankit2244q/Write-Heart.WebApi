using Microsoft.EntityFrameworkCore;
using System;
using Write_heart.Persistence.Db;
using Write_Heart.Application.Business.Service.UserPosts;
using Write_Heart.Domain.Entities;

namespace Write_heart.Persistence.Repository.UserRepo
{
    public class UserPostsRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserPostsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserPosts>> GetAllAsync()
        {
            // Static data for demonstration purposes
            var staticData = new List<UserPosts>
    {
        new UserPosts { Id = 1, Content = "This is the first post.", CreatedAt = DateTime.UtcNow },
        new UserPosts { Id = 2, Content = "This is the second post.", CreatedAt = DateTime.UtcNow },
        new UserPosts { Id = 3, Content = "This is the third post.", CreatedAt = DateTime.UtcNow }
    };

            // Simulate asynchronous operation
            return await Task.FromResult(staticData);
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
