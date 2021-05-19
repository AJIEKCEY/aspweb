using System;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ContractRepo: IContractRepo
    {
        public Contract GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<Contract> GetItems()
        {
            throw new NotImplementedException();
        }

        public void Add(Contract item)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}