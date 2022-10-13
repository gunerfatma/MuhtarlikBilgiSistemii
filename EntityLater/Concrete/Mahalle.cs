using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mahalle
    {
        [Key]
        public int MahalleId { get; set; }
       
        [Required]


        public int MuhtarId { get; set; }
        [StringLength(50)]
        [Required]


        public string MahalleAdi { get; set; }
        [StringLength(50)]
        [Required]


        public string il { get; set; }
        [StringLength(50)]
        [Required]


        public string ilce { get; set; }
        [StringLength(50)]
        [Required]


        public string Konum { get; set; }
        
        [Required]


        public int YuzOlcumu { get; set; }

        public string Baslik2 { get; set; }
        public int Durum2 { get; set; }






        public virtual ICollection<Envanter> Envanter { get; set; }
        public virtual Muhtar Muhtar { get; set; }
        public virtual ICollection<OnemliMekanlar> OnemliMekanlar { get; set; }
    }
}
