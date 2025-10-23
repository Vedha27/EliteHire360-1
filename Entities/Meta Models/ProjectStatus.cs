using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("project_status")]
    public class ProjectStatus
    {
        [Key]
        [Column("project_status_id")]
        public int ProjectStatusId { get; set; }

        [Column("project_status_name")]
        [MaxLength(50)]
        public string ProjectStatusName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
