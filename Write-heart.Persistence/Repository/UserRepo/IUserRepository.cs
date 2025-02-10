using Write_Heart.Domain.Entities;

namespace Write_heart.Persistence.Repository.UserRepo
{
    public interface IUserRepository
    {
      Task<User> GetUserByEmailAsync(string email);
        
    }
}
