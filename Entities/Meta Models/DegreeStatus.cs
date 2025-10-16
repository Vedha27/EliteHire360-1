using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("degree_status")]
    public class DegreeStatus
    {
        [Key]
        [Column("degree_status_id")]
        public int DegreeStatusId { get; set; }

        [Column("degree_status_name")]
        [MaxLength(20)]
        public string DegreeStatusName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
