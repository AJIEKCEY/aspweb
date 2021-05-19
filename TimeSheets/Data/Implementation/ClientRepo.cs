using System;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ClientRepo: IClientRepo
    {
        public Client GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<Client> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Add(Client item)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}