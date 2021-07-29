using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int PollId { get; set; }
        public int PersonId { get; set; }
        public string Title { get; set; }

        public virtual Person Person { get; set; }
        public virtual Poll Poll { get; set; }
        public virtual Question Question { get; set; }
    }
}
