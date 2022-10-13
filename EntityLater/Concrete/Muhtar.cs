using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Muhtar
    {
        [Key]
        public int MuhtarId { get; set; }
        [StringLength(50)]
        [Required]

        public string Adi { get; set; }
        [StringLength(50)]
        [Required]

        public string Soyadi { get; set; }
        
        [Required]


        public int TC { get; set; }
        
        [Required]


        public int TelNo { get; set; }
        [StringLength(100)]
        [Required]

        public string Image { get; set; }
        [StringLength(50)]
        [Required]

        public string Adres { get; set; }
        
        [Required]


        public DateTime DogumTarihi { get; set; }
        
        [Required]


        public int SecilmeYili { get; set; }
        
        [Required]


        public int GorevSuresi { get; set; }
        [StringLength(50)]
        [Required]


        public string Eposta { get; set; }
        [StringLength(8)]
        [Required]
        public string Sifre { get; set; }
        public virtual ICollection<Mahalle> Mahalle { get; set; }
    }
}
