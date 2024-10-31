using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace school_system.models
{
    public class students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string name { get; set; }
        
        [Required]
        public string password { get; set; }

        public int subjectId {  get; set; } 

        public subjects subject {  get; set; }
    }
}
