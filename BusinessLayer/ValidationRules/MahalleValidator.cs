using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MahalleValidator : AbstractValidator<Mahalle>
    {
        public MahalleValidator()
        {
            RuleFor(x => x.MahalleAdi).NotEmpty().WithMessage("Mahalle adı boş geçilemez");
            RuleFor(x => x.il).NotEmpty().WithMessage("Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.ilce).NotEmpty().WithMessage("Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.Konum).NotEmpty().WithMessage("Kutucuğu boş geçemezsiniz ");
            RuleFor(x => x.YuzOlcumu).NotEmpty().WithMessage("Kutucuğu boş geçemezsiniz ");

        }
    }
}
