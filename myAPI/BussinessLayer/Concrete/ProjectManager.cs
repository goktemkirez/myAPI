using myAPI.BussinessLayer.Abstract;
using myAPI.DataAccessLayer.Abstract;
using myAPI.EntityLayer;

namespace myAPI.BussinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public List<Project> TGetAll()
        {
            return _projectDal.GetAll();
        }

        public Project TGetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
