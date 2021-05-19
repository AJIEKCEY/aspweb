using System;

namespace TimeSheets.Models
{
    /// <summary> Информация о владельце контракта </summary>
    public class Client
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}