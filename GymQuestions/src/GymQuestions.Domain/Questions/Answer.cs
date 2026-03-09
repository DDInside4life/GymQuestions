using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuestions.Domain.Questions
{
    public class Answer
    {
        //// Конструктор 
        //public Answer(Guid userId, string text, Question question)
        //{
        //    UserId = userId;
        //    Text = text;
        //    Question = question;
        //}

        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required string Text { get; set; } = string.Empty;

        // Ключевое слово required - при создании объекта,
        // необходимо обязательно заполнить данные
        public required Question Question { get; set; }
        public List<Guid> Comments { get; set; } = [];
    }
}
