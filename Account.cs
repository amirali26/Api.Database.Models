using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate;

// Learn about normal forms
namespace Api.Database.Models
{
    public enum AccountType
    {
        LONDON_LARGE_COMMERCIAL = 0,
        LONDON_AMERICAN_FIRMS = 1,
        LONDON_MID_SIZED_COMMERCIAL = 2,
        LONDON_SMALLER_COMMERCIAL = 3,
        REGIONAL_FIRMS = 4,
        GENERAL_PRACTICE_SMALL_FIRMS = 5,
        NATIONAL_MULTISITE_FIRMS = 6,
        NICHE_FIRMS = 7,
    }
    public class Account : IAccount
    {
        public ICollection<AreasOfPractice> AreasOfPractice { get; set; }
        public ICollection<Enquiry> Enquiries { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }
        [GraphQLName("id")] public string ExternalId { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Website is required")]
        public string Website { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Postcode is required")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Region is required")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Area in region is required")]
        public string AreaInRegion { get; set; }
        public bool FirmVerified { get; set; }
        public string FirmVerificationCode { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public AccountType Size { get; set; }
        [Required(ErrorMessage = "Registration date is required")]
        public DateTime RegisteredDate { get; set; }
        public DateTime CreatedAt { get; set; }
        [InverseProperty("CreatedAccounts")] 
        public User CreatedBy { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<AccountUserInvitation> AccountUserInvitations { get; set; }
        public ICollection<AccountUserPermission> AccountUserPermissions { get; set; }
    }
}