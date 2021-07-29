using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class SysUser
    {
        public SysUser()
        {
            Polls = new HashSet<Poll>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Poll> Polls { get; set; }
    }
}
