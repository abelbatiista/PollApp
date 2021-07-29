using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Person
    {
        public Person()
        {
            Answers = new HashSet<Answer>();
        }

        public int PersonId { get; set; }
        public string Name { get; set; }
        public int PollId { get; set; }

        public virtual Poll Poll { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
