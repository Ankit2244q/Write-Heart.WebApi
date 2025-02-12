using Write_Heart.Application.Interfaces.Generic;

namespace Write_Heart.Application.Business.Service.UserPosts
{
    public class UserPostService
    {

       Public UserPostService(Iuser repository)
        {
            _repository = repository;
        }

        public async Task<UserContent> CreateContentAsync(UserContent content)
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

            return await _repository.AddAsync(content);
        }

        public async Task<IEnumerable<UserContent>> GetUserContentsAsync(string userId)
        {
            return await _repository.GetByUserIdAsync(userId);
        }

        public async Task<bool> DeleteContentAsync(int id, string userId)
        {
            var content = await _repository.GetByIdAsync(id);
            if (content == null || content.UserId != userId)
            {
                throw new UnauthorizedAccessException("You can only delete your own content.");
            }

            return await _repository.DeleteAsync(id);
        }
    }
}
}
