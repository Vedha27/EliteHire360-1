using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels.Organization;
using System.Text.Json;

namespace Entities
{
    [Table("office_loc")]
    public class OfficeLoc
    {
        [Key]
        [Column("office_loc_id")]
        public int Id { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [ForeignKey("Organisation")]
        [Column("organisation_id")]
        public int OrgId { get; set; }

        [Column("name")]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [NotMapped]
        public OfficeInfo? OfficeInfo { get; set; }

        [Column("office_info", TypeName = "json")]
        public string? OfficeInfoJson
        {
            get => OfficeInfo == null ? null : JsonSerializer.Serialize(OfficeInfo);
            set => OfficeInfo = string.IsNullOrWhiteSpace(value)
                ? new OfficeInfo()
                : JsonSerializer.Deserialize<OfficeInfo>(value);
        }

        [Column("created_at")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedOn { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedOn { get; set; }

        // Audit navigation properties
        [ForeignKey("CreatedBy")]
        public virtual User? CreatedByUser { get; set; }
        [ForeignKey("UpdatedBy")]
        public virtual User? UpdatedByUser { get; set; }

        public virtual Organisation Organisation { get; set; } = null!;

        // Navigation property: Jobs in this Office Location
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
