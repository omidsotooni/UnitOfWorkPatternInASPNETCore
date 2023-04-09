using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        #region Fields
        private readonly IUserService _userService;
        #endregion

        #region Constructor
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get the list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserList")]
        public async Task<IActionResult> GetUserList()
        {
            var userDetailsList = await _userService.GetAllUsers();
            if (userDetailsList == null)
            {
                return NotFound();
            }
            return Ok(userDetailsList);
        }
        /// <summary>
        /// Get the list of users that are Adults
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsersAdults")]
        public async Task<IActionResult> GetAdultsUsers()
        {
            var userAdultsList = await _userService.GetAdultUsers();
            if (userAdultsList == null)
            {
                return NotFound();
            }
            return Ok(userAdultsList);
        }
        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("GetUserById/{userId}")]
        public async Task<IActionResult> GetUserById(long userId)
        {
            var userDetails = await _userService.GetUserById(userId);

            if (userDetails != null)
            {
                return Ok(userDetails);
            }
            else
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("Create")]
        public async Task<IActionResult> CreateUser(User user)
        {
            var isUserCreated = await _userService.CreateUser(user);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Update the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            if (user != null)
            {
                var isUserCreated = await _userService.UpdateUser(user);
                if (isUserCreated)
                {
                    return Ok(isUserCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpDelete("Delete/{userId}")]
        public async Task<IActionResult> DeleteUser(long userId)
        {
            var isUserCreated = await _userService.DeleteUser(userId);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        #endregion
    }
}
