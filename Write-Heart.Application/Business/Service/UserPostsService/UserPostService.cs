using Write_Heart.Application.Interfaces.Generic;
using Write_Hear

namespace Write_Heart.Application.Business.Service.UserPosts
{
    public class UserPostService
    {
        private readonly IUserPostsService _userPostsService;
        public UserPostService(IUserPostsService repository)
        {
            _userPostsService = repository;
        }

        public async Task<UserPosts> CreateContentAsync(UserContent content)
        {
            // **Business Logic: Validate before saving**
            if (string.IsNullOrWhiteSpace(content.Content))
            {
                throw new ArgumentException("Content cannot be empty.");
            }

            if (content.Content.Length > 500)
            {
                throw new ArgumentException("Content exceeds 500 characters.");
            }

            return await _userPostsService.AddAsync(content);
        }

        public async Task<IEnumerable<UserContent>> GetUserContentsAsync(string userId)
        {
            return await _userPostsService.GetByUserIdAsync(userId);
        }

        public async Task<bool> DeleteContentAsync(int id, string userId)
        {
            var content = await _userPostsService.GetByIdAsync(id);
            if (content == null || content.UserId != userId)
            {
                throw new UnauthorizedAccessException("You can only delete your own content.");
            }

            return await _userPostsService.DeleteAsync(id);
        }
    }
}
}
