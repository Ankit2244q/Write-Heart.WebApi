using Write_Heart.Domain.Entities;

namespace Write_heart.Persistence.Repository.UserRepo
{
    public interface IUserPostRepository
    {
            Task<IEnumerable<UserPosts>> GetAllAsync();
            Task<UserPosts?> GetByIdAsync(int id);
            Task AddAsync(UserPosts content);
            Task<bool> DeleteAsync(int id);
    }
}
