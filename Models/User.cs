using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ChatForum.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
