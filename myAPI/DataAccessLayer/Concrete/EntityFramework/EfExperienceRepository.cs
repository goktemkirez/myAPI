using Microsoft.EntityFrameworkCore;
using myAPI.DataAccessLayer.Abstract;
using myAPI.DataAccessLayer.Concrete.EntityFramework;
using myAPI.DataAccessLayer.Contexts;
using myAPI.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace myAPI.DataAccessLayer.EntityFramework
{
    public class EfExperienceRepository : GenericRepository<Experience>, IExperienceDal
    {
        Context c = new Context();

        public List<Experience> GetExperiencesWithNestedTables()
        {
            var experience = c.Experiences
                .Include(x => x.ExperienceResponsibilities)
                .Include(x => x.ExperienceProjects)
                .ToList();
            return experience;
        }
    }
}
