using System;

namespace TimeSheets.Models
{
    /// <summary> Информация о сторуднике </summary>
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}