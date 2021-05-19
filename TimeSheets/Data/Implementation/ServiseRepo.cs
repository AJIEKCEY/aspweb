using System;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ServiseRepo: IServiceRepo
    {
        public Service GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<Service> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Add(Service item)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}