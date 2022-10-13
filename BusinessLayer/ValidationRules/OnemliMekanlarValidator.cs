using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OnemliMekanlarValidator: AbstractValidator<OnemliMekanlar>
    {
        public OnemliMekanlarValidator()
        {
            RuleFor(x => x.Adi).NotEmpty().WithMessage("mekan adını boş geçemezsiniz");
            RuleFor(x => x.YapiTipi).NotEmpty().WithMessage("mekan tipi  boş geçemezsiniz");

        }
    }
}
