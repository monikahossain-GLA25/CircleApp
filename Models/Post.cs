using System.ComponentModel.DataAnnotations;
namespace CircleApp.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public string Content { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public int NrOfReports { get; set; } = 0;

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
