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
    public class ActionTypeController : ControllerBase
    {
        private readonly IActionType _IActionType;
        public ActionTypeController(IActionType IActiontype)
        {
            _IActionType = IActiontype;
        }
        //GET: api/ActiontypeController
        [HttpGet]
        public ActionResult<IEnumerable<IActionType>> Get()
        {
            try
            {
                return Ok(_IActionType.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/ActionTypeController/5
        [HttpGet("{id}")]
        public ActionResult<IActionType> Get(string id)
        {
            try
            {
                return Ok(_IActionType.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/ActionTypeController
        [HttpPost]
        public ActionResult Post([FromBody] ActionType Actiontype)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _IActionType.Create(Actiontype);
                    return Ok("Item Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }



        // PUT api/<ActiontypeController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] ActionType Actiontype)
        {
            try
            {
                _IActionType.Update(Actiontype);
                return Ok("Item Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<ActionTypeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                _IActionType.Delete(id);
                return Ok("Item Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}
