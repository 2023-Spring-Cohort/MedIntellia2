using System.ComponentModel.DataAnnotations;
namespace MedIntellia.Models
{
    public class SendMailDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
