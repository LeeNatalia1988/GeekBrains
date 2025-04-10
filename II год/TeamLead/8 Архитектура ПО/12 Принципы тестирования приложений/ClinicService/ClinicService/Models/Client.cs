﻿namespace ClinicService.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Document { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string? Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
