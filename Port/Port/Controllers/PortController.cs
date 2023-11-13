/*
 **********************************
 * Author: Roko Ražov
 * Project Task: Port
 **********************************
 * Description:
 *  
 *  1. Responds to get requests with ship name and port name given in route
 *  2. Responds to get requests with ship name and port name given in query
 *  3. Responds to post requests with port name given in body
 *
 **********************************
 */







using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Port.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class PortController : ControllerBase
    {
        [HttpGet]
        [Route("/port/{shipName}/{portName}")]
        public IActionResult GetNameFromRoute([FromRoute] string shipName, [FromRoute] string portName) 
        {
            return Ok($"Ship {shipName} docked at {portName} Port :: from route");
        }

        [HttpGet]
        [Route("/port")]
        public IActionResult GetNameFromQuery([FromQuery] string shipName, [FromQuery] string portName) 
        {
            return Ok($"Ship {shipName} docked at {portName} Port :: from query");
        }

        [HttpPost]
        [Route("/port")]
        public IActionResult GetNameFromBody([FromBody] string portName)
        {
            return Ok($"Hello from {portName} Port!");
        }


    }
}
