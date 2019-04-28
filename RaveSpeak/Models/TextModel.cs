using System.ComponentModel.DataAnnotations;

namespace RaveSpeak.Models
{
    public class TextModel
    {
        [Required]
        [MaxLength(5000)]
        public string UserText { get; set; }
    }
}
