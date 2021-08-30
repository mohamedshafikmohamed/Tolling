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
    public class LockersController : ControllerBase
    {
        private readonly ILocker _ILocker;
        public LockersController(ILocker Ilocker)
        {
            _ILocker = Ilocker;
        }
        //GET: api/LockerController
        [HttpGet]
        public ActionResult<IEnumerable<Tool>> Get()
        {
            try
            {
                return Ok(_ILocker.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/LockerController/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            try
            {
                return Ok(_ILocker.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/ILockerController
        [HttpPost]
        public ActionResult Post([FromBody] LockerViewModel locker)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _ILocker.Create(locker.locker,locker.locationDetails);
                    return Ok("Item Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }



        // PUT api/<LockerController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] LockerViewModel locker)
        {
            try
            {
                _ILocker.Update(locker.locker,locker.locationDetails);
                return Ok("Item Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<LockerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _ILocker.Delete(id);
                return Ok("Item Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}

