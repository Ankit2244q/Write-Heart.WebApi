namespace Write_heart.Persistence.Repository.UserRepo
{
    public interface IUserRepository
    {
      Task<> GetUserByEmailAsync(string email);
        
    }
}
