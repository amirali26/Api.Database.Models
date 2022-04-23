using System;

namespace Api.Database.Models
{
    public class UserApproval
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int SraNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string PassportNumber { get; set; } 
        public string IdentificationImage { get; set; }
    }
}
