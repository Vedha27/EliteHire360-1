using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    [Table("status_category")]
    public class StatusCategory
    {
        [Key]
        [Column("status_category_id")]
        public int Id { get; set; }

        [Column("status_category_name")]
        [MaxLength(50)]
        public string StatusCategoryName { get; set; } = null!;

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedAt { get; set; }
    }
}
