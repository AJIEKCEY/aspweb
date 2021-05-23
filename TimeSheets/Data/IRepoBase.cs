using System;
using System.Collections.Generic;

namespace TimeSheets.Data
{
    public interface IRepoBase<T>
    {
        T GetItem(Guid id);
        IEnumerable<T> GetItems();
        void Add(T item);
        void Update();
    }
}