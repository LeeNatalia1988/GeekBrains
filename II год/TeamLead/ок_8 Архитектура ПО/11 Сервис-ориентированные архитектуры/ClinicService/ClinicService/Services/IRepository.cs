using ClinicService.Models;

namespace ClinicService.Services
{
    public interface IRepository<T, TId>
    {
        abstract int Create(T item);
        abstract int Update(T item);
        abstract int Delete(TId id);
        abstract T GetById(TId id);
        abstract List<T> GetAll();
    }
}
