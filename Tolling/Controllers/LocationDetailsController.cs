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
    public class LocationDetailsController : ControllerBase
    {
        private readonly ILocationDetails _ILocationDetails;
        public LocationDetailsController(ILocationDetails ILocationDetails)
        {
            _ILocationDetails = ILocationDetails;
        }
        //GET: api/LocationController
        [HttpGet]
        public ActionResult<IEnumerable<LocationDetails>> Get()
        {
            try
            {
                return Ok(_ILocationDetails.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
        /*
        // GET api/ToolController/5
        [HttpGet("{id}")]
        public ActionResult<Location> Get(int id)
        {
            try
            {
                return Ok(_ILocation.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // POST api/LocationController
        [HttpPost]
        public ActionResult Post([FromBody] Location location)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _ILocation.Create(location);
                    return Ok("Location Created successfully");

                }
                else return BadRequest("Some properties are not valid");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }



        // PUT api/<LocationController>/5
        [HttpPut()]
        public ActionResult Put([FromBody] Location location)
        {
            try
            {
                _ILocation.Update(location);
                return Ok("Location Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _ILocation.Delete(id);
                return Ok("Location Deleted");
            }
            catch (Exception e)
            {
                return BadRequest("Error : " + e.Message);
            }
        }
        */
    }
}
