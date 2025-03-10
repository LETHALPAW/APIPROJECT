using APIProjectCamp.Entities;
using FluentValidation;

namespace APIProjectCamp.ValidationRules
{
	public class ProductValidator : AbstractValidator<Product>
	{

		public ProductValidator()
		{
			RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
		}
	}
}

