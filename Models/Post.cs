using ChatForum.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatForum.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; } //class
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; } //enum
        public ICollection<Answer> Answers { get; set; }
        public int Likes { get; set; }
        public Boolean Anonym { get; set; }
    }
}
