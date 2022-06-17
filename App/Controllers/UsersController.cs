using App.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> _users = new List<User>();

        [HttpPost]
        public User Add(User user)
        {
            _users.Add(user);

            return user;
        }
    }
}
