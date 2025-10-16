using Entities.JsonModels;
using Entities.JsonModels.CandidateProfile;
using Entities.MetaModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Entities.MetaModels;
using Entities.JsonModels.Job;

namespace Entities
{
    [Table("application")]
    public class Application
    {
        [Key]
        [Column("application_id")]
        public int ApplicationId { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [ForeignKey("Candidate")]
        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [ForeignKey("Job")]
        [Column("job_id")]
        public int JobId { get; set; }

        [Column("screening")]
        public Screening? Screening { get; set; }

        [Column("is_offer_sent")]
        public int? IsOfferSent { get; set; }

        [Column("is_offer_accepted")]
        public int? IsOfferAccepted { get; set; }

        [NotMapped]
        public ExperienceAndBackground? ExperienceAndBackground { get; set; }

        [Column("experience_and_background", TypeName = "jsonb")]
        public string? ExperienceAndBackgroundJson
        {
            get => ExperienceAndBackground == null ? null : JsonSerializer.Serialize(ExperienceAndBackground);
            set => ExperienceAndBackground = string.IsNullOrWhiteSpace(value)
                ? new ExperienceAndBackground()
                : JsonSerializer.Deserialize<ExperienceAndBackground>(value);
        }

        [Column("resume_path")]
        [MaxLength(55)]
        public string? ResumePath { get; set; }

        [Column("match_percentage")]
        public int? MatchPercentage { get; set; }

        [Column("applied_at")]
        public DateTime AppliedAt { get; set; }

        [ForeignKey("Status")]
        [Column("application_status_id")]
        public int ApplicationStatusId { get; set; }

        [ForeignKey("User")]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        public virtual Candidate Candidate { get; set; } = null!;
        public virtual Job Job { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<ApplicationHistory> ApplicationHistories { get; set; } = new List<ApplicationHistory>();
        public virtual ICollection<ScheduledInterview> ScheduledInterviews { get; set; } = new List<ScheduledInterview>();
    }
}
