using System.Collections.Generic;

namespace TempleManagementSystem.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        List<T> GetAll();
    }
}
