using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate;

namespace Api.Database.Models
{
    public enum AccountUserInvitationStatus
    {
        PENDING = 0,
        REJECTED = 1,
        ACCEPTED = 2,
        ACCOUNT_REJECTED = 3,
    }
    public class AccountUserInvitation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }
        [GraphQLName("id")] public string ExternalId { get; set; }
        [Required(ErrorMessage = "User email is required")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Referer user is required")]
        public User ReferUser { get; set; }
        [Required(ErrorMessage = "Account is requited")]
        public Account Account { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public AccountUserInvitationStatus Status { get; set; }
    }
}