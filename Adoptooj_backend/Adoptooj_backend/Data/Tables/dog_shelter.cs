using System.ComponentModel.DataAnnotations;

namespace Adoptooj_backend.Data.Tables
{
    public class dog_shelter
    {
        [Key]
        public int id { get; set; }
        [MaxLength(64)]
        public string name { get; set; }
        [MaxLength(255)]
        public string email { get; set; }
        [MaxLength(30)]
        public string city { get; set; }
        [MaxLength(6)]
        public string post_code { get; set; }
        [MaxLength(56)]
        public string street { get; set; }
        [MaxLength(10)]
        public string street_number { get; set; }
        [MaxLength(10)]
        public string apartment_number { get; set; }

        public float lat { get; set; }
        public float lon { get; set; }
    }
}
