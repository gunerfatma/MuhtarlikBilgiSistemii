using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hizmetler
    {
        [Key]
        public int HizmetId { get; set; }
        [Required]
        public int MuhtarId { get; set; }
        public String Baslik { get; set; }
        [Required]
        public String Aciklama { get; set; }
        [Required]
        public String Durum { get; set; }
        [Required]
        public decimal Maliyet { get; set; }
        [Required]
        public String MuhtarAdiSoyadi { get; set; }
        [Required]
        public DateTime MuhtarGirisTarihi { get; set; }
        [Required]
        public string DevamEdenPersonelAdiSoyadi { get; set; }
        [Required]
        public decimal MaliyetTutari { get; set; }
        [Required]
        public DateTime BelediyeGirisTarihi { get; set; }
        [Required]
        public string TamamlandiPersonelAdiSoyadi { get; set; }
        [Required]
        public DateTime TamamlandiBitisTarihi { get; set; }

        public virtual Muhtar Muhtar { get; set; }
    }
}
