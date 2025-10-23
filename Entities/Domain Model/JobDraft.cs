using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Text.Json;
using Entities.JsonModels.Job;

namespace Entities
{
    [Table("job_draft")]
    public class JobDraft
    {
        [Key]
        [Column("job_draft_id")]
        public int Id { get; set; }

        [ForeignKey("Job")]
        [Column("job_id")]
        public int JobId { get; set; }

        [Column("job_title")]
        public string? JobTitle { get; set; }

        [Column("department_id")]
        public int? DepartmentId { get; set; }

        [NotMapped]
        public List<InterviewRound>? InterviewProcess { get; set; } = new List<InterviewRound>();

        [Column("interview_process", TypeName = "jsonb")]
        public string? InterviewProcessJson
        {
            get => InterviewProcess == null ? null : JsonSerializer.Serialize(InterviewProcess);
            set => InterviewProcess = string.IsNullOrWhiteSpace(value)
                ? new List<InterviewRound>()
                : JsonSerializer.Deserialize<List<InterviewRound>>(value);
        }

        [Column("location_id")]
        public int? LocationId { get; set; }

        [Column("emp_type_id")]
        public int? EmpType { get; set; }

        [Column("organisation_id")]
        public int? OrganisationId { get; set; }

        [Column("work_mode_id")]
        public int? WorkMode { get; set; }

        [Column("min_salary")]
        public long? MinSalary { get; set; }

        [Column("max_salary")]
        public long? MaxSalary { get; set; }

        [NotMapped]
        public JobDescription? JobDesc { get; set; }

        [Column("job_desc", TypeName = "json")]
        public string? JobDescJson
        {
            get => JobDesc == null ? null : JsonSerializer.Serialize(JobDesc);
            set => JobDesc = string.IsNullOrWhiteSpace(value)
                ? new JobDescription()
                : JsonSerializer.Deserialize<JobDescription>(value);
        }

        [ForeignKey("Status")]
        [Column("job_status_id")]
        public int? JobStatusId { get; set; }

        [Column("experience_level_id")]
        public int? ExperienceLevelId { get; set; }

        [Column("priority_level_id")]
        public int? PriorityLevel { get; set; }

        [Column("job_deadline_at")]
        public DateTime? JobDeadline { get; set; }

        [Column("created_at")]
        public DateTime? CreatedOn { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedOn { get; set; }

        [Column("updated_by")]
        public string? UpdatedBy { get; set; }

        public virtual Job Job { get; set; } = null!;
    }
}
