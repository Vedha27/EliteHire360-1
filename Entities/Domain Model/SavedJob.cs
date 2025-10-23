using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("saved_job")]
    public class SavedJob
    {
        [Key]
        [Column("saved_job_id")]
        public int Id { get; set; }

        [ForeignKey("Candidate")]
        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [ForeignKey("Job")]
        [Column("job_id")]
        public int JobId { get; set; }

        [Column("is_applied")]
        public int IsApplied { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public virtual Candidate Candidate { get; set; } = null!;
        public virtual Job Job { get; set; } = null!;
    }
}
