using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("office_type")]
    public class OfficeType
    {
        [Key]
        [Column("office_type_id")]
        public int Id { get; set; }

        [Column("office_type_name")]
        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
