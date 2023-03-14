using BackendApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuraiController : ControllerBase
    {
        [HttpGet]
        public Samurai Get()
        {
            Samurai samurai1 = new Samurai() 
            {
                Id = 1,
                Name = "Sasaki Tajuro"
            };
            return samurai1;
        }
    }
}
