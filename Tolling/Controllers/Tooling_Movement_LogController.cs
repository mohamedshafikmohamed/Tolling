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
    public class Tooling_Movement_LogController : ControllerBase
    {
       
        private readonly ITooling_Movement_Log _ITooling_Movement_Log;
        public Tooling_Movement_LogController(ITooling_Movement_Log ITooling_Movement_log)
        {
            _ITooling_Movement_Log = ITooling_Movement_log;
        }
        //GET: api/Tooling_Movement_LogController
        [HttpGet]
        public ActionResult<IEnumerable<Tooling_Movement_Log>> Get()
        {
            try
            {
                return Ok(_ITooling_Movement_Log.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/Tooling_Movement_LogController/5
        [HttpGet("{id}")]
        public ActionResult<Tooling_Movement_Log> Get(int id)
        {
            try
            {
                return Ok(_ITooling_Movement_Log.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/Tooling_Movement_LogController
        [HttpPost]
        public ActionResult Post([FromBody] Tooling_Movement_Log Tooling_Movement_log)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _ITooling_Movement_Log.Create(Tooling_Movement_log);
                    return Ok("Item Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }



        // PUT api/<Tooling_Movement_LogController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] Tooling_Movement_Log Tooling_Movement_log)
        {
            try
            {
                _ITooling_Movement_Log.Update(Tooling_Movement_log);
                return Ok("Item Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<Tooling_Movement_LogController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _ITooling_Movement_Log.Delete(id);
                return Ok("Item Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}
