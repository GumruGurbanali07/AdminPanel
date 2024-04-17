using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior: AbstractValidator<Category>
    {
        public CategoryValidatior() {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Write Category Name");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Write Category Description");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Please write at least 3 characters");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Please write a maximum of 20 characters");


        }
    }
}
