using System.Data;
using FluentValidation;
using GymQuestions.Contracts;
using GymQuestions.Contracts.Questions;

namespace GymQuestions.Application.Questions;

public class CreateQuestionValidator : AbstractValidator<CreateQuestionDto>
{
    public CreateQuestionValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MaximumLength(500)
            .WithMessage("Title is not valid");
        
        RuleFor(x => x.Text)
            .NotEmpty()
            .MaximumLength(5000)
            .WithMessage("Text is not valid");

        RuleFor(x => x.UserId)
            .NotEmpty();

        RuleForEach(x => x.TagIds)
            .NotEmpty();
    }
}