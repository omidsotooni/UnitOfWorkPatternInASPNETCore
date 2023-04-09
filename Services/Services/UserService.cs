using Domain.Entities;
using Domain.Interfaces;
using Services.Interfaces;

namespace Services.Services
{
    public class UserService : IUserService
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods
        public async Task<bool> CreateUser(User user)
        {
            if (user != null)
            {
                await _unitOfWork.User.Add(user);
                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteUser(long userId)
        {
            if (userId > 0)
            {
                var user = await _unitOfWork.User.GetById(userId);
                if (user != null)
                {
                    _unitOfWork.User.Delete(user);
                    var result = _unitOfWork.Save();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAdultUsers()
        {
            var userAdultList = await _unitOfWork.User.GetAdultUsers();
            return userAdultList;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var userList = await _unitOfWork.User.GetAll();
            return userList;
        }

        public async Task<User> GetUserById(long userId)
        {
            if (userId > 0)
            {
                var user = await _unitOfWork.User.GetById(userId);
                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<bool> UpdateUser(User user)
        {
            if (user != null)
            {
                var userFind = await _unitOfWork.User.GetById(user.UserId);
                if (userFind != null)
                {
                    userFind.Name = user.Name;
                    userFind.Age = user.Age;
                    userFind.StreetAdress = user.StreetAdress;
                    userFind.HouseNumber = user.HouseNumber;
                    userFind.City = user.City;
                    userFind.Province = user.Province;
                    userFind.PostalCode = user.PostalCode;
                    userFind.EmailAdress = user.EmailAdress;
                    _unitOfWork.User.Update(userFind);
                    var result = _unitOfWork.Save();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        #endregion
    }
}
