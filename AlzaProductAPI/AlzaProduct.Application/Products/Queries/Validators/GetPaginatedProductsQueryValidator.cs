using FluentValidation;

namespace AlzaProduct.Application.Products.Queries.Validators;

public class GetPaginatedProductsQueryValidator : AbstractValidator<GetPaginatedProductsQuery>
{
    public GetPaginatedProductsQueryValidator()
    {
        RuleFor(x => x.PageSize).GreaterThan(0);
        RuleFor(x => x.PageIndex).GreaterThan(0);
    }
}
