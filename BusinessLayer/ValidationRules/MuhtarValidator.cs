using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MuhtarValidator : AbstractValidator<Muhtar>
    {
        public MuhtarValidator()
        {
            RuleFor(x => x.Adres).NotEmpty().WithMessage("Muhtar adı boş geçilemez");
            RuleFor(x => x.Soyadi).NotEmpty().WithMessage("Muhtar soyadı boş geçilemez");
            RuleFor(x => x.TC).NotEmpty().WithMessage("Muhtar TC boş geçilemez");
            RuleFor(x => x.TelNo).NotEmpty().WithMessage("Muhtar Telefon boş geçilemez");
            RuleFor(x => x.Adres).NotEmpty().WithMessage("Muhtar adres boş geçilemez");
            RuleFor(x => x.DogumTarihi).NotEmpty().WithMessage("Muhtar doğum tarihi boş geçilemez");
            RuleFor(x => x.SecilmeYili).NotEmpty().WithMessage("Muhtar seçilme yılı boş geçilemez");
            RuleFor(x => x.GorevSuresi).NotEmpty().WithMessage("Muhtar görev süresi boş geçilemez");
            RuleFor(x => x.Eposta).NotEmpty().WithMessage("Muhtar mail boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Muhtar resim boş geçilemez");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre adını boş geçemezsiniz");
            RuleFor(x => x.Sifre).MinimumLength(7).WithMessage("şifre min 7 karakter olmalı ");
            RuleFor(x => x.Sifre).MaximumLength(7).WithMessage("şifre max 8 olmalı");
        }
    }
}
