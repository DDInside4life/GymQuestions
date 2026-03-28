using FluentValidation;
using GymQuestions.Contracts.Questions;
using GymQuestions.Domain.Questions;
using Microsoft.Extensions.Logging;

namespace GymQuestions.Application.Questions;

public class QuestionsService : IQuestionsService
{
    
    private readonly IQuestionsRepository _questionsRepository;
    private readonly ILogger<QuestionsService> _logger;
    private readonly IValidator<CreateQuestionDto> _validator;

    public QuestionsService(
        IQuestionsRepository questionsRepository,
        IValidator<CreateQuestionDto> validator,
        ILogger<QuestionsService> logger
        )
    {
        _questionsRepository = questionsRepository;
        _validator = validator;
        _logger = logger;
    }

    public async Task<Guid> Create(CreateQuestionDto questionDto, CancellationToken cancellationToken)
    {
        // check validation
        
        // input data validation
        var validationResult = await _validator.ValidateAsync(questionDto, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        // business logic validation
        int openUserQuestionsCount = await _questionsRepository
            .GetOpenUserQuestionsAsync(questionDto.UserId, cancellationToken);

        if (openUserQuestionsCount > 3)
        {
            throw  new ValidationException("Too many open user questions.");
        }
        
        
        
        // create Question entities 
        
        var questionId = Guid.NewGuid();

        var question = new Question(
            questionId,
            questionDto.Title,
            questionDto.Text,
            questionDto.UserId,
            null,
            questionDto.TagIds
        );
    
        
        // saving entity Question in database 
        
        await _questionsRepository.AddAsync(question, cancellationToken);
        

        // logs about saving 
        
        _logger.LogInformation($"Question {questionId} created.", questionId);

        throw new InvalidOperationException();
    }
}