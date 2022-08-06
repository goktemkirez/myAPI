using Microsoft.EntityFrameworkCore;
using myAPI.DataAccessLayer.Abstract;
using myAPI.DataAccessLayer.Concrete.EntityFramework;
using myAPI.DataAccessLayer.Contexts;
using myAPI.EntityLayer.Concrete;
using System.Linq.Expressions;
using System.Reflection;

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

        public Experience GetByIdWithNestedTables(int id)
        {
            var experience = c.Experiences
                .Include(x => x.ExperienceResponsibilities)
                .Include(x => x.ExperienceProjects)
                .FirstOrDefault(x => x.ExperienceID == id);
            return experience;
        }

        public void DeleteWithNestedTables(Experience experience)
        {
            c.RemoveRange(experience.ExperienceResponsibilities);
            c.RemoveRange(experience.ExperienceProjects);
            c.Remove(experience);
            c.SaveChanges();
        }

        public void InsertWithNestedTables(Experience experience)
        {
            c.AddRange(experience.ExperienceResponsibilities);
            c.AddRange(experience.ExperienceProjects);
            c.Add(experience);
            c.SaveChanges();
        }

        public void UpdateWithNestedTables(Experience experience)
        {
            c.UpdateRange(experience.ExperienceResponsibilities);
            c.UpdateRange(experience.ExperienceProjects);
            c.Update(experience);
            c.SaveChanges();
        }
    }
}
