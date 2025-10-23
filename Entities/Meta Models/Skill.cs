using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.MetaModels
{
    [Table("skill")]
    public class Skill
    {
        [Key]
        [Column("skill_id")]
        public int SkillId { get; set; }

        [Column("skill_name")]
        [MaxLength(50)]
        public string SkillName { get; set; } = null!;

        [ForeignKey("SkillCategory")]
        [Column("skill_category_id")]
        public int SkillCategoryId { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
