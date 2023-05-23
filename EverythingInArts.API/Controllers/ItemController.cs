using Microsoft.AspNetCore.Mvc;
using EverythingInArts.Application;
using EverythingInArts.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EverythingInArts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
        {
            _service = service;
        }

        // GET: api/<ItemController>
        [HttpGet]
        public ActionResult <List<Item>> Get()
        {
            return Ok(_service.GetAllItems()); ; ;
        }

        
    }
}
