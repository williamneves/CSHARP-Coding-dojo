using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWallAssignment.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // Relationships
        // Each message has a user
        public int UserId { get; set; }
        public User User { get; set; }
        
        // 1 Message to many Comments
        public List<Comment> Comments { get; set; }
    }
}