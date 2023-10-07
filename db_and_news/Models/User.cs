using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace db_and_news.Models
{
    public class User
    {
        [Key]
        public int id_users { get; set; }

        [Required]
        public string? SName { get; set; }

        [Required]
        public string? SEmail { get; set; }

        [Required]
        public int SPhone { get; set; }

        public DateTime SDate { get; set; }
    }
}


