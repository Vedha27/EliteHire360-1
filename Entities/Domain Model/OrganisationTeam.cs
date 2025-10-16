using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("organisation_team")]
    public class OrganisationTeam
    {
        [Key]
        [Column("organisation_team_id")]
        public int Id { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [Column("first_name")]
        [MaxLength(55)]
        public string FirstName { get; set; } = null!;

        [Column("last_name")]
        [MaxLength(40)]
        public string LastName { get; set; } = null!;

        [Column("email")]
        [MaxLength(55)]
        public string Email { get; set; } = null!;

        [ForeignKey("SubRole")]
        [Column("sub_role_id")]
        public int SubRoleId { get; set; }

        [ForeignKey("Department")]
        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("message")]
        [MaxLength(55)]
        public string? Message { get; set; }

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
    }
}
