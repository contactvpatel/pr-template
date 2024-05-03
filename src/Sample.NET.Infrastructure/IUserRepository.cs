using Sample.NET.Core;

namespace Sample.NET.Infrastructure
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task<int> UpdateAsync(User user);
        Task<bool> DeleteAsync(User id);
        Task<int> AddAsync(User user);
    }
}
