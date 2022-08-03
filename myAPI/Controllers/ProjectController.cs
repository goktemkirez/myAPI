using Microsoft.AspNetCore.Mvc;
using myAPI.DataAccessLayer;
using myAPI.EntityLayer;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult All()
        {
            using var c = new MySqlContext();
            var values = c.Projects?.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Project project)
        {
            using var c = new MySqlContext();
            c.Add(project);
            c.SaveChanges();
            return Ok(project);
        }
    }
}
