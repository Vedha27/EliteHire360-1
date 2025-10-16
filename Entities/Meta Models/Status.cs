using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.MetaModels
{
    [Table("status")]
    public class Status
    {
        [Key]
        [Column("status_id")]
        public int StatusId { get; set; }

        [Column("status_name")]
        [MaxLength(50)]
        public string StatusName { get; set; } = null!;

        [ForeignKey(nameof(StatusCategory))]
        [Column("status_category_id")]
        public int StatusCategoryId { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        public virtual StatusCategory StatusCategory { get; set; } = null!;
    }
}
