using DbExample.DB;
using DbExample.Models;
using DbExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DbExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService UserService;
        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }
        // POST api/<UserController>
        [HttpPost]
        public User Post(User user)
        {
            try
            {
                UserService.Insert(user);
               

                return user;

            }
            catch(Exception ex)
            {

            }

            return null;
        }

        // POST api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            // 

            return  UserService.GetAll();
        }


    }
}
