using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("project_category")]
    public class ProjectCategory
    {
        [Key]
        [Column("project_category_id")]
        public int ProjectCategoryId { get; set; }

        [Column("project_category_name")]
        [MaxLength(50)]
        public string ProjectCategoryName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
