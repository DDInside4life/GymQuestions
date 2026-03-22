namespace GymQuestions.Contracts;

// record - ссылочный тип с неизменяемыми свойствами
public record CreateQuestionDto(string Title, string Body, Guid UserId, Guid[] TagIds);