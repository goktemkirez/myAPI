using myAPI.EntityLayer.Concrete;

namespace myAPI.BussinessLayer.Abstract
{
    public interface IExperienceService : IGenericService<Experience>
    {
        public List<Experience> TGetExperiencesWithNestedTables();
    }
}
