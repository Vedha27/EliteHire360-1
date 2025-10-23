using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("interview_format")]
    public class InterviewFormat
    {
        [Key]
        [Column("interview_format_id")]
        public int InterviewFormatId { get; set; }

        [Column("interview_format_name")]
        [MaxLength(50)]
        public string InterviewFormatName { get; set; } = null!;

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}
