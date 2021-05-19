using System;

namespace TimeSheets.Data
{
    public interface IRepoBase<T>
    {
        T GetItem(Guid id);
        IEquatable<T> GetItems();
        void Add(T item);
        void Update();
    }
}