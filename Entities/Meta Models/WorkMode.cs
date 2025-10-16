using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("work_mode")]
    public class WorkMode
    {
        [Key]
        [Column("work_mode_id")]
        public int Id { get; set; }

        [Column("work_mode_name")]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        // Navigation property: One WorkMode can be used by many Jobs
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
