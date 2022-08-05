using myAPI.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace myAPI.DataAccessLayer.Abstract
{
    public interface IExperienceDal : IGenericDal<Experience>
    {
        List<Experience> GetExperiencesWithNestedTables();
    }
}
