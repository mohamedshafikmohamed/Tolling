using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Interfaces;
using Tolling.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tolling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _Iuser;
        public UserController(IUser Iuser)
        {
            _Iuser = Iuser;
        }
        //GET: api/UserController
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            try
            {
                return Ok(_Iuser.GetUsers());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/UserController/5
        [HttpGet("{id}")]
        public  ActionResult<User> Get(int id)
        {
            try
            {
                return Ok(_Iuser.GetUser(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/UserController
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            try
            {
                
                user.Password = _Iuser.MD5Hash(user.Password);
                if (ModelState.IsValid)
                {
                    
                    _Iuser.Create(user);
                    return Ok("User Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch(Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        [HttpGet]
        [Route("SignIn")]
        public ActionResult SignIn([FromBody]SignIn signIn)
        {
            try
            {
                signIn.Password = _Iuser.MD5Hash(signIn.Password);
                return Ok(_Iuser.SignIn(signIn));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }

        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] User user)
        {
            try
            {
                _Iuser.Update(user);
                return Ok("User Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _Iuser.Delete(id);
                return Ok("User Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}
