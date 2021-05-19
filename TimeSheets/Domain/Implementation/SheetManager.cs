using System;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Data.Interfaces;
using TimeSheets.Domain.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Domain.Implementation
{
    public class SheetManager: ISheetManager
    {
        private readonly ISheetRepo _sheetRepo;

        public SheetManager(ISheetRepo sheetRepo)
        {
            _sheetRepo = sheetRepo;
        }

        public Sheet GetItem(Guid id)
        {
            return _sheetRepo.GetItem(id);
        }

        public Guid Create(SheetCreateRequest sheetRequest)
        {
            var sheet = new Sheet()
            {
                Amount = sheetRequest.Amount,
                ContractId = sheetRequest.ContractId,
                Date = sheetRequest.Date,
                EmployeeId = sheetRequest.EmployeeId,
                ServiceId = sheetRequest.ServiceId,
                Id = Guid.NewGuid()
            };
            
            _sheetRepo.Add(sheet);

            return sheet.Id;
        }
    }
}