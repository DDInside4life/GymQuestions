namespace GymQuestions.Contracts;

public record UpdateQuestionDto(string Title, string Body, Guid[] TagIds);