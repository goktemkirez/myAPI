using Microsoft.AspNetCore.Mvc;
using myAPI.BussinessLayer.Concrete;
using myAPI.DataAccessLayer.EntityFramework;
using myAPI.EntityLayer.Concrete;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : Controller
    {
        ExperienceManager manager = new ExperienceManager(new EfExperienceRepository());

        // GET: api/Experiences
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = manager.TGetAll();
            return Ok(values);
        }

        // GET: api/Experiences/10
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var experience = manager.TGetById(id);
            return experience == null ? NotFound() : Ok(experience);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var experience = manager.TGetById(id);
            if (experience == null)
                return NotFound();
            else
            {
                manager.TDelete(experience);
                return Ok();
            }
        }

        [HttpPost]
        public IActionResult Insert(Experience experience)
        {
            manager.TAdd(experience);
            return Ok(experience);
        }

        [HttpPut]
        public IActionResult Update(Experience experience)
        {
            try
            {
                manager.TUpdate(experience);
                return Ok(experience);

            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

        }
    }
}
