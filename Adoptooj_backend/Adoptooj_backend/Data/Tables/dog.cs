using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class dog
    {
        [Key]
        public int id { get; set; }
        public int dog_shelter_id { get; set; }
        [MaxLength(64)]
        public string name { get; set; }
        [MaxLength(2)]
        public string age { get; set; }
        [MaxLength(38)]
        public string race { get; set; }
        public int[] disease_id { get; set; }
    }
}
