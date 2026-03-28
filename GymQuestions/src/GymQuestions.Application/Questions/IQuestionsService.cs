using GymQuestions.Contracts.Questions;

namespace GymQuestions.Application.Questions;

public interface IQuestionsService
{
    Task <Guid> Create(CreateQuestionDto questionDto, CancellationToken cancellationToken);
}