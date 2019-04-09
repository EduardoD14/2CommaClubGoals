using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwoCommaClubGoals.Entities;

namespace TwoCommaClubGoals.Models
{
    public class LessonIndexViewModel
    {
        public IEnumerable<Lesson> Lessons { get; set; }
        public Paging Paging { get; set; }
        public string CurrentCategory { get; set; }
    }
}