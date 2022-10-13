using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(50)]
        [Required]
        public string KullanıcıAdi { get; set; }
        [StringLength(50)]
        [Required]
        public string Password { get; set; }
        [StringLength(1)]
        [Required]
        public string AdminYetkili { get; set; }
    }
}
