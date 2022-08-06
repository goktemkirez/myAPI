using myAPI.EntityLayer.Concrete;

namespace myAPI.BussinessLayer.Abstract
{
    public interface IExperienceService : IGenericService<Experience>
    {
        public List<Experience> TGetExperiencesWithNestedTables();
        Experience TGetByIdWithNestedTables(int id);
        void TDeleteWithNestedTables(Experience experience);
        void TAddWithNestedTables(Experience experience);
        void TUpdateWithNestedTables(Experience experience);
    }
}
