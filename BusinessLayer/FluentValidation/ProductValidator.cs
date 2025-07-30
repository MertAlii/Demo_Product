using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=> x.ProductName).NotEmpty().WithMessage("Ürün Adını Boş Geçemezsiniz");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün Adı En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Ürün Stok Bilgisini Boş Geçemezsiniz");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün Fiyat Bilgisini Boş Geçemezsiniz");

        }
    }
}
