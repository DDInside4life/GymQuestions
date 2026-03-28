using FluentValidation;
using GymQuestions.Application;
using GymQuestions.Application.Questions;
using Microsoft.Extensions.DependencyInjection;

namespace GymQuestions.Web;

public static class DependencyInjection
{
    public static IServiceCollection AddProgramDependencies(this IServiceCollection services)
    {
       return services
           .AddWebDependencies()
           .AddApplication();
    }

    private static IServiceCollection AddWebDependencies(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();
        
        return services;
    }
}