namespace GymQuestions.Contracts.Questions;

// record - ссылочный тип с неизменяемыми свойствами
public record CreateQuestionDto(string Title, string Text, Guid UserId, Guid[] TagIds);