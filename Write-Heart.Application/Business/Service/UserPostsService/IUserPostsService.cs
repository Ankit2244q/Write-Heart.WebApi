
namespace Write_Heart.Application.Business.Service.UserPosts

{
    public interface IUserPostsService
    {

        Task<UserPosts> CreateContentAsync(content);
        Task<IEnumerable<UserContent>> GetUserContentsAsync(string userId);
        Task<bool> DeleteContentAsync(int id, string userId);

    }
}
