using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Validators
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> builder)
        {
            return builder
                .NotEmpty()
                .MinimumLength(6).WithMessage("Password must be at least 6 characters.")
                .Matches("[A-Z]").WithMessage("Password must have at least 1 uppercase letter.")
                .Matches("[a-z]").WithMessage("Password must have at least 1 lowercase letter.")
                .Matches("[0-9]").WithMessage("Password must contain a number.")
                .Matches("[a-zA-Z0-9]").WithMessage("PAssword must contain non-alphanumeric");
        }
    }
}
