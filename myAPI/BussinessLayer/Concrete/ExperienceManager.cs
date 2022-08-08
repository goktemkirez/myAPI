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
            _experienceDal.InsertWithNestedTables(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.DeleteWithNestedTables(t);
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetByIdWithNestedTables(id);
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.UpdateWithNestedTables(t);
        }

        public List<Experience> TGetAll()
        {
            return _experienceDal.GetExperiencesWithNestedTables();
        }
    }
}
