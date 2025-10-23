using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.MetaModels
{
    [Table("sub_role")]
    public class SubRole
    {
        [Key]
        [Column("sub_role_id")]
        public int SubRoleId { get; set; }

        [Column("permission_id")]
        public int PermissionId { get; set; }

        [Column("sub_role_name")]
        [MaxLength(30)]
        public string SubRoleName { get; set; } = null!;

        [Column("role_desc")]
        [MaxLength(256)]
        public string RoleDesc { get; set; } = null!;

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}
