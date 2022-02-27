using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotChocolate;

namespace Api.Database.Models
{
    public enum AccountPermission
    {
        ADMIN = 1,
        BASIC = 2,
        READ_ONLY = 3,
    }
    
    public class AccountUserPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [GraphQLIgnore]
        public int Id { get; set; }
        [Required(ErrorMessage = "Account is required")]
        public Account Account { get; set; }
        [Required(ErrorMessage = "User is required")]
        public User User { get; set; }
        [Required(ErrorMessage = "Permission is required")]
        public AccountPermission AccountPermission { get; set; }
    }
}