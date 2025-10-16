using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("experience_level")]
    public class ExperienceLevel
    {
        [Key]
        [Column("experience_level_id")]
        public int ExpId { get; set; }

        [Column("experience_level")]
        [MaxLength(50)]
        public string ExpLevel { get; set; } = null!;

        [Column("experience_description")]
        [MaxLength(50)]
        public string ExpDesc { get; set; } = null!;

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}
