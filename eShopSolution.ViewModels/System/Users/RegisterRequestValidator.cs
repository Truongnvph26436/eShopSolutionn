using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("First name is required").MaximumLength(200)
                .WithMessage("First name cannot over 200 characters");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Last name is required").MaximumLength(200)
                .WithMessage("Last name cannot over 200 characters");
            RuleFor(c => c.Dob).GreaterThan(DateTime.Now.AddYears(-100))
                .WithMessage("Birthday cannot greater than 100 years");
            RuleFor(c => c.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email format not match");
            RuleFor(c => c.PhoneNumber).NotEmpty().WithMessage("Phone number is  required").Length(10);
            RuleFor(c => c.UserName).NotEmpty().WithMessage("User name is required");
            RuleFor(c => c.Password).NotEmpty().WithMessage("Password is required").MinimumLength(6)
                .WithMessage("Password is at least 6 characters");

            RuleFor(c => c).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
        }
    }
}