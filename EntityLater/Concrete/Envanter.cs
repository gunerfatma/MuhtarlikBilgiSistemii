using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Envanter
    {
        [Key]
        public int EnvanterId { get; set; }
        [Required]

        public int MahalleId { get; set; }
        [Required]

        public int Nufus { get; set; }
        [Required]

        public int BinaSayisi { get; set; }
        [Required]

        public int HaneSayisi { get; set; }
        [Required]

        public int OkulSayisi { get; set; }
        [Required]

        public int YolAgiUzunlugu { get; set; }
        [Required]

        public int ErkekNufus { get; set; }
        [Required]

        public int KadinNufus { get; set; }
        [Required]

        public int AVMSayisi { get; set; }
        [Required]

        public int YolYapiSayisi { get; set; }

        public String Baslik1 { get; set; }
        public int Durum1 { get; set; }

        public virtual Mahalle Mahalle { get; set; }
    }
}
