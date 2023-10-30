using LessonNINE.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace LessonNINE.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(200);

        [HttpGet]
        public string Get()
        {
            return _users;
        }

        [HttpGet("{id}")]
        public User Get (int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);   
            return user;
        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editeUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editeUser.Firstname = user.Firstname;
            editeUser.Lastname = user.Lastname;
            editeUser.Address = user.Address;
            return user;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deleteUsr = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deleteUser);
        }
    }
}
