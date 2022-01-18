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
        public Account Account { get; set; }
        public User User { get; set; }
        public AccountPermission AccountPermission { get; set; }
    }
}