using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Poll
    {
        public Poll()
        {
            Answers = new HashSet<Answer>();
            People = new HashSet<Person>();
            Questions = new HashSet<Question>();
        }

        public int PollId { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }

        public virtual SysUser User { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
