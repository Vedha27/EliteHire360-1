using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("industry")]
    public class Industry
    {
        [Key]
        [Column("industry_id")]
        public int IndustryId { get; set; }

        [Column("industry_name")]
        [MaxLength(50)]
        public string IndustryName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
