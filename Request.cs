using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using HotChocolate;

namespace Api.Database.Models
{
    public class Request : IRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }
        [Required]
        public int RequestNumber { get; set; }
        [GraphQLName("id")] public string ExternalId { get; set; }
        [MaxLength(300, ErrorMessage = "Request message too long")]
        [MinLength(20, ErrorMessage = "Request Message too short")]
        public string Description { get; set; }
        [Required]
        public AreasOfPractice Topic { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required(ErrorMessage = "Postcode is required")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Region is required")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Area in region is required")]
        public string AreaInRegion { get; set; }
        public ICollection<Enquiry> Enquiries { get; set; }
    }
}
