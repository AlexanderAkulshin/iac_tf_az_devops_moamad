using Microsoft.AspNetCore.Mvc;

namespace sampleapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var persons = new[]{
                "Mohamad",
                "Donald duck",
                "Mickey",
                "Batman",
                "Thor",
                "Tony Stark"
            };
            return Ok(persons);
        }
    
    }
}