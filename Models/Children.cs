using System.ComponentModel.DataAnnotations;

namespace LGC_Check_In.Models
{
    public class Children
    {
        [Key]
        public int RecordID { get; set; }
        [Required]
        public int GuardianPhone { get; set; }
        [Required]
        public int GeneratedCode { get; set; }


    }
}
