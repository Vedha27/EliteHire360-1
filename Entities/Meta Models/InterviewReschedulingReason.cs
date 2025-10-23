using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    public class InterviewReschedulingReason
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Reason { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
