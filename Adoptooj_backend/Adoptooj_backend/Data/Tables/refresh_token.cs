using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adoptooj_backend.Data.Tables
{
    public class refresh_token
    {
        [Key]
        public int id { get; set; }
        [MaxLength(36)] 
        public string user_id { get; set; }
        [MaxLength(500)]
        public string token { get; set; }
    }
}
