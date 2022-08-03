using Microsoft.AspNetCore.Mvc;
using myAPI.BussinessLayer.Concrete;
using myAPI.DataAccessLayer;
using myAPI.DataAccessLayer.EntityFramework;
using myAPI.EntityLayer;

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
    }
}
