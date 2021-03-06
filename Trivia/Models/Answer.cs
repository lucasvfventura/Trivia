﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Trivia.Models
{
    public class Answer : IModelBase
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
    }
}
