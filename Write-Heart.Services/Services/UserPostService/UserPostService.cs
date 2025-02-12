using Write_heart.Persistence.Repository.UserRepo;
using Write_Heart.Application.Business.Service.UserPosts;
using Write_Heart.Domain.Entities;

namespace Write_Heart.Services.Services.UserPostService
{
    public class UserPostService : IUserPostService
    {

        private IUserRepository _userPostRepo;

        public UserPostService(UserPostsRepository userPostsRepository)
        {
            _userPostRepo =  userPostsRepository;
        }



        public Task AddAsync(UserPosts content)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Domain.Entities.UserPosts>> GetAllAsync()
        {
            return _userPostRepo.GetAllAsync();
        }

        public Task<UserPosts> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
