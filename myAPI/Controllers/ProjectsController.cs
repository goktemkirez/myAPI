using Microsoft.AspNetCore.Mvc;
using myAPI.BussinessLayer.Concrete;
using myAPI.DataAccessLayer;
using myAPI.DataAccessLayer.EntityFramework;
using myAPI.EntityLayer.Concrete;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : Controller
    {
        ProjectManager manager = new ProjectManager(new EfProjectRepository());

        [HttpGet]
        public IActionResult All()
        {
            var values = manager.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Project project)
        {
            manager.TAdd(project);
            return Ok(project);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = manager.TGetById(id);
            return project == null ? NotFound() : Ok(project);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = manager.TGetById(id);
            if (project == null)
                return NotFound();
            else
            {
                manager.TDelete(project);
                return Ok();
            }
        }


        [HttpPut]
        public IActionResult Update(Project project)
        {
            try
            {
                manager.TUpdate(project);
                return Ok(project);

            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
