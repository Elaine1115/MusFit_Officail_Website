﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Lab1212_todo_mvc.Models
{
    public partial class Term
    {
        public Term()
        {
            ClassTimes = new HashSet<ClassTime>();
        }

        public int TId { get; set; }
        public TimeSpan TStartTime { get; set; }
        public TimeSpan TEndTime { get; set; }

        public virtual ICollection<ClassTime> ClassTimes { get; set; }
    }
}
