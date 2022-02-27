using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate;

namespace Api.Database.Models
{
    public enum Status
    {
        OPEN = 1,
        CONTACTED = 2,
        IN_COMMUNCATION = 3
    }

    public class Enquiry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }
        [GraphQLName("id")] public string ExternalId { get; set; }
        [Required(ErrorMessage = "Please provide an enquiry message")]
        [MaxLength(300, ErrorMessage = "Enquiry message too long")]
        [MinLength(50, ErrorMessage = "Enquiry Message too short")]
        public string Message { get; set; }
        [Required]
        public int InitialConsultationFee { get; set; }
        public int? EstimatedPrice { get; set; }
        public bool OfficeAppointment { get; set; }
        public bool PhoneAppointment { get; set; }
        public bool VideoCallAppointment { get; set; }
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "nvarchar(24)")] 
        public Status Status { get; set; }
        [Required]
        public Request Request { get; set; }
        [Required]
        public Account Account { get; set; }
        [Required]
        public User User { get; set; }
    }
}