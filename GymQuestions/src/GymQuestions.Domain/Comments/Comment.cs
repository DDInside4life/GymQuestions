using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuestions.Domain.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }

        // Родительский комментарий и список дочерних комментариев 
        public Comment? Parent {  get; set; } // nullable свойство
        public List<Comment> Children { get; set; } = [];

        // Для масштабируемости и производительности 
        public required Guid EntityId { get; set; }

        
    }
}
