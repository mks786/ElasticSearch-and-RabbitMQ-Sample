using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbitMQ.Transfer.Domain.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar(100)")]
        [StringLength(maximumLength: 100, ErrorMessage = "Must be less than 100 characters", MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "Varchar(100)")]
        [StringLength(maximumLength: 100, ErrorMessage = "Must be less than 100 characters", MinimumLength = 1)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
