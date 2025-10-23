using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("department")]
    public class Department
    {
        [Key]
        [Column("department_id")]
        public int DeptId { get; set; }

        [Column("department_name")]
        [MaxLength(20)]
        public string DeptName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }

        // Navigation property: Jobs in this Department
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
