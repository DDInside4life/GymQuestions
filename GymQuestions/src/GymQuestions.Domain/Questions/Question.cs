using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuestions.Domain.Questions
{
    public class Question
    {
        public Guid Id { get; set; }

        public required string Title { get; set; } = string.Empty;
        public required string Text { get; set; } = string.Empty;

        // Связь с другим модулем User через Id
        public required Guid UserId { get; set; }
        public Guid? ScreenshotId { get; set; }

        // List of answers
        public List<Answer> Answers { get; set; } = [];

        // nullable свойство
        // В данном случае прямая ссылка допустима тк Answer и Question в одном модуле
        public Answer? Solution { get; set; }

        // Ссылка на теги в виде списка Guid
        public List<Guid> Tags { get; set; } = [];

        // Комментарии в виде списка Guid
        //public List<Guid> Comments { get; set; } = [];
    }

   
}

