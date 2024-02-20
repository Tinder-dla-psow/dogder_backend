using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class role
    {
        [Key]
        public int id { get; set; }
        [MaxLength(64)]
        public string name { get; set; }
        public int[] right { get; set; }
    }
}
