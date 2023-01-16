using System.ComponentModel.DataAnnotations;

namespace LGC_Check_In.Models
{
    public class Guardian
    {
        [Key]
        public int RecordID { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
    }
}
