using Domain.Entities;

namespace Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> CreateUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(long userId);
        Task<bool> UpdateUser(User userDetails);
        Task<bool> DeleteUser(long userId);
        Task<IEnumerable<User>> GetAdultUsers();
    }
}
