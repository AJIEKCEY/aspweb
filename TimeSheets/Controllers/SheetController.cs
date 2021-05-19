using System;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Domain.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SheetController: ControllerBase
    {
        private readonly ISheetManager _sheetManager;

        public SheetController(ISheetManager sheetManager)
        {
            _sheetManager = sheetManager;
        }

        [HttpGet]
        public IActionResult Get(Guid id)
        {
            var result = _sheetManager.GetItem(id);
            
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SheetCreateRequest sheet)
        {
            var id = _sheetManager.Create(sheet);
            return Ok(id);
        }
    }
}