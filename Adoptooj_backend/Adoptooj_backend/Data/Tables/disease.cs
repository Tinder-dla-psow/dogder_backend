using Npgsql;
using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class disease
    {
            [Key]
            public int id { get; set; }

            [Required]
            [MaxLength(36)]
            public string name { get; set; }

            [MaxLength(1500)]
            public string desc { get; set; }
        
    }
}