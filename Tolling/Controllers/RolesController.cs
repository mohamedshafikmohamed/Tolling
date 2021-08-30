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
    [Route("[controller]")]
    [ApiController]
    //Tested
    public class RolesController : ControllerBase
    {
        private readonly IRole _IRole;
        public RolesController(IRole iRole)
        {
            _IRole =iRole;
        }
        //GET: api/RoleController
        [HttpGet]
        public ActionResult<IEnumerable<Role>> Get()
        {
            try
            {
                return Ok(_IRole.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/RoleController/5
        [HttpGet("{id}")]
        public ActionResult<Role> Get(string id)
        {
            try
            {
                return Ok(_IRole.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/ToolController
        [HttpPost]
        public ActionResult Post([FromBody] Role role)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _IRole.Create(role);
                    return Ok("Role Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }


/*
        // PUT api/<RoleController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] Role role)
        {
            try
            {
                _IRole.Update(role);
                return Ok("Role Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
*/
        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                _IRole.Delete(id);
                return Ok("Role Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}
