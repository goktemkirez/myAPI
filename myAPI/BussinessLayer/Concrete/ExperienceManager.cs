using myAPI.BussinessLayer.Abstract;
using myAPI.DataAccessLayer.Abstract;
using myAPI.EntityLayer.Concrete;

namespace myAPI.BussinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public List<Experience> TGetExperiencesWithNestedTables()
        {
            return _experienceDal.GetExperiencesWithNestedTables();
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetAll()
        {
            throw new NotImplementedException();
        }

        public void TDeleteWithNestedTables(Experience experience)
        {
            _experienceDal.DeleteWithNestedTables(experience);
        }

        public Experience TGetByIdWithNestedTables(int id)
        {
            return _experienceDal.GetByIdWithNestedTables(id);
        }
    }
}
