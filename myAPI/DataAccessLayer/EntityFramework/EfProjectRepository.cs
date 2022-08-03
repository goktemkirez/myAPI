using myAPI.DataAccessLayer.Abstract;
using myAPI.DataAccessLayer.Repositories;
using myAPI.EntityLayer;

namespace myAPI.DataAccessLayer.EntityFramework
{
    public class EfProjectRepository : GenericRepository<Project>, IProjectDal
    {
    }
}
