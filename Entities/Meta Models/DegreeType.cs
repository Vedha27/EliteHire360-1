using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("degree_type")]
    public class DegreeType
    {
        [Key]
        [Column("degree_type_id")]
        public int DegreeTypeId { get; set; }

        [Column("degree_type_name")]
        [MaxLength(20)]
        public string DegreeTypeName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
