using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels.Job;
using System.Text.Json;

namespace Entities
{
    [Table("scheduled_interview")]
    public class ScheduledInterview
    {
        [Key]
        [Column("scheduled_interview_id")]
        public int Id { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [ForeignKey("Application")]
        [Column("application_id")]
        public int ApplicationId { get; set; }

        [Column("parent_interview_id")]
        public int? ParentInterviewId { get; set; }

        [ForeignKey("InterviewFormat")]
        [Column("interview_format_id")]
        public int InterviewFormat { get; set; }

        [Column("interview_mode")]
        [MaxLength(20)]
        public string InterviewMode { get; set; } = null!;

        [Column("scheduled_date")]
        public DateTime ScheduledDate { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("duration")]
        public int Duration { get; set; }

        [Column("status")]
        [MaxLength(40)]
        public string Status { get; set; } = null!;

        [NotMapped]
        public InterviewFeedback? InterviewFeedback { get; set; }

        [Column("interview_feedback", TypeName = "json")]
        public string? InterviewFeedbackJson
        {
            get => InterviewFeedback == null ? null : JsonSerializer.Serialize(InterviewFeedback);
            set => InterviewFeedback = string.IsNullOrWhiteSpace(value)
                ? new InterviewFeedback()
                : JsonSerializer.Deserialize<InterviewFeedback>(value);
        }

        [Column("location")]
        [MaxLength(55)]
        public string? Location { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        public virtual Application Application { get; set; } = null!;

        // Navigation property for ScheduledInterviewHistory
        public virtual ICollection<ScheduledInterviewHistory> ScheduledInterviewHistories { get; set; } = new List<ScheduledInterviewHistory>();
    }
}
