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
    public class ToolsController : ControllerBase
    {
        private readonly ITool _ITool;
        public ToolsController(ITool ITool)
        {
            _ITool = ITool;
        }
        //GET: api/ToolController
        [HttpGet]
        public ActionResult<IEnumerable<Tool>> Get()
        {
            try
            {
                return Ok(_ITool.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/ToolController/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(string id)
        {
            try
            {
                return Ok(_ITool.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/ToolController
        [HttpPost]
        public ActionResult Post([FromBody] Tool tool)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _ITool.Create(tool);
                    return Ok("Item Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

       

        // PUT api/<ToolController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] Tool tool)
        {
            try
            {
                _ITool.Update(tool);
                return Ok("Item Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<ToolController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                _ITool.Delete(id);
                return Ok("Item Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}
