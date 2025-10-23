using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.MetaModels
{
    [Table("role")]
    public class Role
    {
        [Key]
        [Column("role_id")]
        public int Id { get; set; }

        [Column("role_name")]
        [MaxLength(20)]
        public string RoleName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
