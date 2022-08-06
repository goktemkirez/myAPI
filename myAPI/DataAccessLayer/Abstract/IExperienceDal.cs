using myAPI.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace myAPI.DataAccessLayer.Abstract
{
    public interface IExperienceDal : IGenericDal<Experience>
    {
        List<Experience> GetExperiencesWithNestedTables();
        Experience GetByIdWithNestedTables(int id);
        void DeleteWithNestedTables(Experience experience);
        void InsertWithNestedTables(Experience experience);
        void UpdateWithNestedTables(Experience experience);
    }
}
