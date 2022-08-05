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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var experience = manager.TGetByIdWithNestedTables(id);
            return experience == null ? NotFound() : Ok(experience);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var experience = manager.TGetByIdWithNestedTables(id);
            if (experience == null)
                return NotFound();
            else
            {
                manager.TDeleteWithNestedTables(experience);
                return Ok();
            }
        }
    }
}
