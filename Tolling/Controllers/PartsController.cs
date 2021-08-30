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
    public class PartsController : ControllerBase
    {
        // GET: api/<PartController>
        private readonly IPart _IPart;
        public PartsController(IPart Ipart)
        {
            _IPart = Ipart;
        }
        //GET: api/PartController
        [HttpGet]
        public ActionResult<IEnumerable<Part>> Get()
        {
            try
            {
                return Ok(_IPart.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // GET api/PartController/5
        [HttpGet("{id}")]
        public ActionResult<Part> Get(string id)
        {
            try
            {
                return Ok(_IPart.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/PartController
        [HttpPost]
        public ActionResult Post([FromBody] PartViewModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _IPart.Create(model.part,model.toolpart);
                    return Ok("Item Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }



        // PUT api/<PartController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] PartViewModel part)
        {
            try
            {
                _IPart.Update(part.part,part.toolpart);
                return Ok("Item Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<PartController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                _IPart.Delete(id);
                return Ok("Item Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
    }
}
