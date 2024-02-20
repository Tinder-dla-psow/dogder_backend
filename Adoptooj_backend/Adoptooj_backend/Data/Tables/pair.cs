using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class pair
    {
        [Key]
        public int id { get; set; }
        [MaxLength(36)]
        public string user_id { get; set; }
        [MaxLength(36)]
        public string dog_id { get; set; }
    }
}
