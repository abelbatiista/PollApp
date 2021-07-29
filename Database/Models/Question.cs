using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int PollId { get; set; }

        public virtual Poll Poll { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
