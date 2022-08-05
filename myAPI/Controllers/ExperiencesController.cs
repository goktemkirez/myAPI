using Microsoft.AspNetCore.Mvc;
using myAPI.BussinessLayer.Concrete;
using myAPI.DataAccessLayer.EntityFramework;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : Controller
    {
        ExperienceManager manager = new ExperienceManager(new EfExperienceRepository());

        [HttpGet]
        public IActionResult All()
        {
            var values = manager.TGetExperiencesWithNestedTables();
            return Ok(values);
        }
    }
}
