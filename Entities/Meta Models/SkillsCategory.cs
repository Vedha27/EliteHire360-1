using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("skills_category")]
    public class SkillsCategory
    {
        [Key]
        [Column("skill_category_id")]
        public int SkillCategoryId { get; set; }

        [Column("skill_category_name")]
        [MaxLength(50)]
        public string SkillCategoryName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
