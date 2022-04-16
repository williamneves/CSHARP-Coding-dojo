using System.ComponentModel.DataAnnotations;

namespace Wedding.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }
        public User GuestUser { get; set; }
        public Wedding Wedding { get; set; }
    }
}