using Write_Heart.Application.Interfaces.Generic;
using Write_Heart.Domain.Entities;


namespace Write_Heart.Application.Business.Service.UserPosts
{
    public class UserPostService
    {
        private readonly IUserPostsService _userPostsService;
        public UserPostService(IUserPostsService repository)
        {
            _userPostsService = repository;
        }

        public async Task<Domain.Entities.UserPosts> CreateContentAsync(Domain.Entities.UserPosts content)
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

            return null; 
        }

        public async Task<IEnumerable<Domain.Entities.UserPosts>> GetUserContentsAsync(string userId)
        {
            return null;
        }

        public async Task<bool> DeleteContentAsync(int id, string userId)
        {
            //var content = '';
            //if (content == null || content.UserId != userId)
            //{
            //    throw new UnauthorizedAccessException("You can only delete your own content.");
            //}

            //return await _userPostsService.DeleteAsync(id);

            return true;
        }
    }

}
