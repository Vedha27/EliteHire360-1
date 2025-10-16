using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("employment_type")]
    public class EmploymentType
    {
        [Key]
        [Column("employment_type_id")]
        public int EmploymentTypeId { get; set; }

        [Column("employment_type_name")]
        [MaxLength(50)]
        public string EmploymentTypeName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
    }
}
