using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public class ErrorViewModel
    {
        [Key]
        [Required]
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}