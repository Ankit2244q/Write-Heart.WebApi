using System.ComponentModel.DataAnnotations;

namespace Write_Heart.Domain.Entities
{
    public class UserPosts
    {
            [Key]
            public int Id { get; set; }

            [Required]
            public string UserId { get; set; } = string.Empty; 

            [Required]
            public string ContentType { get; set; } = string.Empty; 

            [Required]
            public string Content { get; set; } = string.Empty;

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        }
    
}
