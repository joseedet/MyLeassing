using System.ComponentModel.DataAnnotations;


namespace MyLeassing.Common.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
