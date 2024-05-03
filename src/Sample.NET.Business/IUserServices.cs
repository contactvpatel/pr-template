using Sample.NET.Core;

namespace Sample.NET.Business
{
    public interface IUserServices
    {
        Task<int> CreateUserAsync(string name, string email, string gender, int age);
        Task<User> GetUserAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<int> UpdateUserAsync(int id, string name, string email, string gender, int age);
        Task<bool> DeleteUserAsync(int id);
    }
}