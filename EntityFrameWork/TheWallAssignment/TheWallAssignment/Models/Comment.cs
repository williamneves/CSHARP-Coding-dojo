using System;
using System.ComponentModel.DataAnnotations;

namespace TheWallAssignment.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public int MessageId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User User { get; set; }
        public Message Message { get; set; }
    }
}