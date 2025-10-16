using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("application_history")]
    public class ApplicationHistory
    {
        [Key]
        [Column("application_history_id")]
        public int Id { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [ForeignKey("Application")]
        [Column("application_id")]
        public int ApplicationId { get; set; }

        [Column("status_id")]
        public int StatusId { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        public virtual Application Application { get; set; } = null!;
    }
}
