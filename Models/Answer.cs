using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatForum.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; } 
        public int Likes { get; set; }
        public DateTime Date { get; set; }

        public int PostId { get; set; } 
        public Post Post { get; set; }
    }
}
