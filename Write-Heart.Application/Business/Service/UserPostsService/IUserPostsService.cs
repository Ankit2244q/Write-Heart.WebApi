
using Write_Heart.Domain.Entities;

namespace Write_Heart.Application.Business.Service.UserPosts
{
    public interface IUserPostsService
    {

        Task<Domain.Entities.UserPosts> CreateContentAsync();
        Task<IEnumerable<Domain.Entities.User>> GetUserContentsAsync(string userId);
        Task<bool> DeleteContentAsync(int id, string userId);

    }
}
