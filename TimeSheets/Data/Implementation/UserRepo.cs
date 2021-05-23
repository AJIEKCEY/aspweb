using System;
using System.Collections.Generic;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class UserRepo: IUserRepo
    {
        public User GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}