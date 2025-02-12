
using Write_Heart.Domain.Entities;

namespace Write_Heart.Application.Business.Service.UserPosts
{
    public interface IUserRepository
    {
        Task<IEnumerable<Domain.Entities.UserPosts>> GetAllAsync();
        Task<Domain.Entities.UserPosts> GetByIdAsync(int id);
        Task AddAsync(Domain.Entities.UserPosts content);
        Task<bool> DeleteAsync(int id);
    }
}
