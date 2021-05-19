using System;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class EmployeeRepo: IEmployeeRepo
    {
        public Employee GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<Employee> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Add(Employee item)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}