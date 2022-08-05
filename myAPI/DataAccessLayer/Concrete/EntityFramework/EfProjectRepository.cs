using myAPI.DataAccessLayer.Abstract;
using myAPI.DataAccessLayer.Concrete.EntityFramework;
using myAPI.EntityLayer.Concrete;

namespace myAPI.DataAccessLayer.EntityFramework
{
    public class EfProjectRepository : GenericRepository<Project>, IProjectDal
    {
    }
}
