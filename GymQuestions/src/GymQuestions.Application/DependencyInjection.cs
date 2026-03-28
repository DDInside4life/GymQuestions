using FluentValidation;
using GymQuestions.Application.Questions;
using Microsoft.Extensions.DependencyInjection;

namespace GymQuestions.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        services.AddScoped<IQuestionsService, QuestionsService>();
        
        return services;
    }
}