using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels;
using Entities.JsonModels.Organization;
using System.Text.Json;

namespace Entities
{
    [Table("organisation")]
    public class Organisation
    {
        [Key]
        [Column("organisation_id")]
        public int Id { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [Column("name")]
        [MaxLength(55)]
        public string Name { get; set; } = null!;

        [Column("industry")]
        [MaxLength(55)]
        public string? Insudstry { get; set; }

        [NotMapped]
        public CompanyOverview? Overview { get; set; }

        [Column("overview", TypeName = "jsonb")]
        public string? OverviewJson
        {
            get => Overview == null ? null : JsonSerializer.Serialize(Overview);
            set => Overview = string.IsNullOrWhiteSpace(value)
                ? new CompanyOverview()
                : JsonSerializer.Deserialize<CompanyOverview>(value);
        }

        [NotMapped]
        public CompanyCulture? Culture { get; set; }

        [Column("culture", TypeName = "jsonb")]
        public string? CultureJson
        {
            get => Culture == null ? null : JsonSerializer.Serialize(Culture);
            set => Culture = string.IsNullOrWhiteSpace(value)
                ? new CompanyCulture()
                : JsonSerializer.Deserialize<CompanyCulture>(value);
        }

        [Column("benefit")]
        [MaxLength(55)]
        public string? Benefit { get; set; }

        [ForeignKey("OfficeLoc")]
        [Column("office_loc_id")]
        public int OfficeLocId { get; set; }

        [Column("organisation_status")]
        public int OrganizationStatus { get; set; }

        [Column("created_at")]
        public DateTime CreatedOn { get; set; }

        [ForeignKey("User")]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedOn { get; set; }

        [ForeignKey("User")]
        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedOn { get; set; }

        public virtual OfficeLoc OfficeLoc { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
