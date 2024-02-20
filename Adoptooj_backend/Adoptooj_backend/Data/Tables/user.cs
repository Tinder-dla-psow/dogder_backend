using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class user
    {
        [MaxLength(36)]
        public string id { get; set; }
        public int role_id { get; set; }
        [MaxLength(64)]
        public string username { get; set; }
        [MaxLength(255)]
        public string email { get; set; }
        [MaxLength(64)]
        public string password { get; set; }
        public bool is_active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? archive_date { get; set; }
    }
}
