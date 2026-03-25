using Microsoft.AspNetCore.Mvc;

namespace JenkinWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Status = "Healthy",
                Time = DateTime.Now
            });
        }
    }
}