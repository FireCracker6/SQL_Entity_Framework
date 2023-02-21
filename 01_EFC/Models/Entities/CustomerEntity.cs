

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _01_EFC.Models.Entities
{
    [Index(nameof(Email), IsUnique =true)]


    internal class CustomerEntity
    {
    
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]  
        public string FirstName { get; set; } = null!;

        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [StringLength(100)]
        public string Email { get; set; } = null!;

        [Column(TypeName = "char(13)")]
        public string? PhoneNumber { get; set; }

        [Required]
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;
    }
}

