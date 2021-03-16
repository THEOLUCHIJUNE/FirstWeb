using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWeb.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        
        [Required(ErrorMessage = "Please insert your Full Name...")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please insert your Age...")]
        public string Age { get; set; }
        
        [Required(ErrorMessage = "Please insert your Room Number...")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please insert Amount...")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        
        
        
    }
}