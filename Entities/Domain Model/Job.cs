using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Collections.Generic;
using Entities.MetaModels;
using System.Text.Json;
using Entities.JsonModels.Job;

namespace Entities
{
    [Table("job")]
    public class Job
    {
        [Key]
        [Column("job_id")]
        public int Id { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [Column("job_title")]
        [MaxLength(30)]
        public string JobTitle { get; set; } = null!;

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

        [ForeignKey("Department")]
        [Column("department_id")]
        public int DepartmentId { get; set; }

        [ForeignKey("OfficeLoc")]
        [Column("location_id")]
        public int LocationId { get; set; }

        [ForeignKey("EmploymentType")]
        [Column("employment_type_id")]
        public int EmpType { get; set; }

        [ForeignKey("Organisation")]
        [Column("organisation_id")]
        public int OrganisationId { get; set; }

        [ForeignKey("WorkMode")]
        [Column("work_mode_id")]
        public int WorkMode { get; set; }

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
        public int JobStatusId { get; set; }

        [ForeignKey("ExperienceLevel")]
        [Column("experience_level_id")]
        public int ExperienceLevelId { get; set; }

        [ForeignKey("PriorityLevel")]
        [Column("priority_level_id")]
        public int PriorityLevel { get; set; }

        [Column("job_deadline_at")]
        public DateTime? JobDeadline { get; set; }

        [Column("created_at")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        [MaxLength(100)]
        public string CreatedBy { get; set; } = null!;

        [Column("updated_at")]
        public DateTime? UpdatedOn { get; set; }

        [Column("updated_by")]
        [MaxLength(100)]
        public string? UpdatedBy { get; set; }

        public virtual Organisation Organisation { get; set; } = null!;
        public virtual Department Department { get; set; } = null!;
        public virtual EmploymentType EmploymentType { get; set; } = null!;
        public virtual ExperienceLevel ExperienceLevel { get; set; } = null!;
        public virtual PriorityLevel PriorityLevelNavigation { get; set; } = null!;
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
