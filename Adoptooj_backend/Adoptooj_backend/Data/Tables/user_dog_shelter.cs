using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class user_dog_shelter
    {
        [Key]
        public int id { get; set; }
        [MaxLength(36)]
        public string user_id { get; set; }
        public int dog_shelter_id { get; set; }
    }
}
