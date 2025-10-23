using Entities.MetaModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("user_role_mapping")]
    public class UserRoleMapping
    {
        [Key]
        [Column("user_role_mapping_id")]
        public int UserRoleMappingId { get; set; }

        [ForeignKey("User")]
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("Role")]
        [Column("role_id")]
        public int RoleId { get; set; }

        [ForeignKey("SubRole")]
        [Column("sub_role_id")]
        public int SubroleId { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("deleted_by")]
        public int? DeletedBy { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual SubRole SubRole { get; set; } = null!;
    }
}
