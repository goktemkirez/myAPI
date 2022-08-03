namespace myAPI.BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
