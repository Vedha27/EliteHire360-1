using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("priority_level")]
    public class PriorityLevel
    {
        [Key]
        [Column("priority_level_id")]
        public int Id { get; set; }

        [Column("priority_level_name")]
        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [Column("priority_level_description")]
        [MaxLength(20)]
        public string Description { get; set; } = null!;

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }
    }
}
