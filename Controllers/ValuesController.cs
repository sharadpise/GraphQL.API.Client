using GraphQL.API.Client.Client;
using GraphQL.API.Client.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.API.Client.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class ValuesController: ControllerBase
    {
        private readonly OwnerConsumer _consumer;
        public ValuesController(OwnerConsumer consumer)
        {
            _consumer = consumer;
        }
        
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            var owners = await _consumer.GetAllOwners();
            return Ok(owners);
        }

        //[HttpGet("GetOwnerById/{id}")]        
        //public async Task<Owner> GetOwnerById([FromRoute] string id)
        //{

        //    //Owner owner = await _consumer.GetOwner(id);
        //    return new Owner();
        //}
    }
}
