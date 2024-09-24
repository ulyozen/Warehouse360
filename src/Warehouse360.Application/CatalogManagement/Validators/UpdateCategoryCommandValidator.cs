using FluentValidation;
using Warehouse360.Application.CatalogManagement.Commands;

namespace Warehouse360.Application.CatalogManagement.Validators;

public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCategoryCommandValidator()
    {
        RuleFor(c => c.CategoryId)
            .NotEmpty().WithMessage("Category ID is required.");

        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category name is required.")
            .MaximumLength(100).WithMessage("Category name must be less than 100 characters.");

        RuleFor(c => c.Description)
            .MaximumLength(500).WithMessage("Description must be less than 500 characters.");
    }
}