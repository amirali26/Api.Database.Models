using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate;

namespace Api.Database.Models
{
    public class UserApproval
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }
        [GraphQLName("id")] public string ExternalId { get; set; }
        public User User { get; set; }
        public int SraNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string PassportNumber { get; set; } 
        public string IdentificationImage { get; set; }
    }
}
