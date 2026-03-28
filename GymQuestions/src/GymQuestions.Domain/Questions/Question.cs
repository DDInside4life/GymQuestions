using System;
using System.Collections.Generic;
using System.Text;
using GymQuestions.Domain.Tags;

namespace GymQuestions.Domain.Questions
{
    public class Question
    {
        public Question(
            Guid id,
            string title,
            string text,
            Guid userId,
            Guid? screenshotId,
            IEnumerable<Guid> tags)
        {
            Id = id;
            Title = title;
            Text = text;
            UserId = userId;
            ScreenshotId = screenshotId;
            Tags = tags.ToList();
        }
        
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;

        // Связь с другим модулем User через Id
        public Guid UserId { get; set; }
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
        
        public QuestionStatus Status { get; set; } =  QuestionStatus.Open;
    }
}

