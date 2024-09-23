using System.ComponentModel.DataAnnotations;

namespace Clinic.API.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Phone]
        public string? Phone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string Address { get; set; }

        public string? MedicalHistory { get; set; }
    }
}