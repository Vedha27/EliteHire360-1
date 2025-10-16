using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Collections.Generic;
using Entities.JsonModels.CandidateProfile;
using System.Text.Json;

namespace Entities
{
    [Table("candidate")]
    public class Candidate
    {
        [Key]
        [Column("candidate_id")]
        public int CandidateId { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [ForeignKey("User")]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("resume_path")]
        [MaxLength(55)]
        public string? ResumePath { get; set; }

        [Column("overall_experience")]
        public int? OverallExperience { get; set; }

        [NotMapped]
        public CandidateProfile? CandidateProfile { get; set; }

        [Column("candidate_profile", TypeName = "jsonb")]
        public string? CandidateProfileJson
        {
            get =>JsonSerializer.Serialize(CandidateProfile);
            set => CandidateProfile = string.IsNullOrWhiteSpace(value)
                ? new CandidateProfile()
                : JsonSerializer.Deserialize<CandidateProfile>(value);
        }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
