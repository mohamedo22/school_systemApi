using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace school_system.models
{
    public class subjects
    {
        [Key]
        public int subjectId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
