using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate;

namespace Api.Database.Models
{
    public class Client : IClient
    {
        public ICollection<Request> Requests { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }

        [GraphQLName("id")] public string ExternalId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(30, ErrorMessage = "Name should not be longer than 30 chars")]
        [MinLength(5, ErrorMessage = "Name should be longer than 5 chars")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}