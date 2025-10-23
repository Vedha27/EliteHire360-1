using Entities.MetaModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("scheduled_interview_history")]
    public class ScheduledInterviewHistory
    {
        [Key]
        [Column("scheduled_interview_history_id")]
        public int Id { get; set; }

        [ForeignKey("ScheduledInterview")]
        [Column("scheduled_interview_id")]
        public int InterviewId { get; set; }

        [ForeignKey("Status")]
        [Column("status_id")]
        public int InterviwStatusId { get; set; }

        [ForeignKey("User")]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreateAt { get; set; }

        public virtual ScheduledInterview ScheduledInterview { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
