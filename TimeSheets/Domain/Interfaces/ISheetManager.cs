using System;
using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Domain.Interfaces
{
    public interface ISheetManager
    {
        Sheet GetItem(Guid id);
        Guid Create(SheetCreateRequest sheet);
    }
}