using Entities.MetaModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("job_history")]
    public class JobHistory
    {
        [Key]
        [Column("job_history_id")]
        public int Id { get; set; }

        [ForeignKey("Job")]
        [Column("job_id")]
        public int JobId { get; set; }

        [ForeignKey("Status")]
        [Column("job_status_id")]
        public int JobStatusId { get; set; }

        [ForeignKey("User")]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreateAt { get; set; }

        public virtual Job Job { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
