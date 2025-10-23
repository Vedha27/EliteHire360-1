using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("unique_key")]
        public Guid UniqueKey { get; set; }

        [Column("first_name")]
        [MaxLength(55)]
        public string FirstName { get; set; } = null!;

        [Column("last_name")]
        [MaxLength(40)]
        public string LastName { get; set; } = null!;

        [Column("phone")]
        [MaxLength(20)]
        public string Phone { get; set; } = null!;

        [Column("email")]
        [MaxLength(55)]
        public string Email { get; set; } = null!;

        [Column("location")]
        [MaxLength(55)]
        public string Location { get; set; } = null!;

        [Column("password")]
        [MaxLength(55)]
        public string Password { get; set; } = null!;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("created_by")]
        public int CreatedBy { get; set; }

        [Column("last_login_at")]
        public DateTime? LastLogin { get; set; }

        [Column("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [Column("deleted_by")]
        public int? DeletedBy { get; set; }

        [Column("updated_by")]
        public int? UpdatedBy { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        public virtual UserRoleMapping? UserRoleMapping { get; set; }
        public virtual Candidate? Candidate { get; set; }
        public virtual Organisation? Organisation { get; set; }
    }
}
