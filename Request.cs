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
        public int RequestNumber { get; set; }
        [GraphQLName("id")] public string ExternalId { get; set; }
        public string Description { get; set; }
        public AreasOfPractice Topic { get; set; }
        public DateTime CreatedDate { get; set; }
        public Client Client { get; set; }
        public string PostCode { get; set; }
        public string Region { get; set; }
        public string AreaInRegion { get; set; }
        public bool ShowPhoneNumber { get; set; }
        public ICollection<Enquiry> Enquiries { get; set; }
    }
}
