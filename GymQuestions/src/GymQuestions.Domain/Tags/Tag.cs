using System;
using System.Collections.Generic;

using System.Text;

namespace GymQuestions.Domain.Tags
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
