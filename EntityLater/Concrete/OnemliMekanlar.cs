using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OnemliMekanlar
    {
        
        [Key]
        public int OnemliMekanlarId { get; set; }

        [Required]
        public int MahalleId { get; set; }

        [StringLength(50)]
        [Required]
        public string Adi { get; set; }
        [StringLength(50)]
        [Required]
        public string YapiTipi { get; set; }

        public virtual Mahalle Mahalle { get; set; }


    }
}
