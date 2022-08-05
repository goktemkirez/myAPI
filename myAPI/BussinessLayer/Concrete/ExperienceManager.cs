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
            throw new NotImplementedException();
        }

        public List<Experience> TGetExperiencesWithNestedTables()
        {
            return _experienceDal.GetExperiencesWithNestedTables();
        }

        public Experience TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetAll()
        {
            throw new NotImplementedException();
        }
    }
}
