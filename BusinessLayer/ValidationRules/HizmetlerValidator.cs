using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HizmetlerValidator : AbstractValidator<Hizmetler>
    {
        public HizmetlerValidator()
        {
            RuleFor(x => x.Baslik).NotEmpty().WithMessage(" Başığı boş geçemezsiniz");
            RuleFor(x => x.Aciklama).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.Durum).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.Maliyet).NotEmpty().WithMessage(" Kutucuğu boş geçemezsinizz");
            RuleFor(x => x.MuhtarAdiSoyadi).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.MuhtarGirisTarihi).NotEmpty().WithMessage("Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.DevamEdenPersonelAdiSoyadi).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.MaliyetTutari).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.BelediyeGirisTarihi).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.TamamlandiPersonelAdiSoyadi).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");
            RuleFor(x => x.TamamlandiBitisTarihi).NotEmpty().WithMessage(" Kutucuğu boş geçemezsiniz");

        }
    }
}
