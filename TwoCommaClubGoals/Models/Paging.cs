using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace TwoCommaClubGoals.Models
{
    public class Paging
    {       
       public int TotalLessons { get; set; }
       public int LessonsPerPage { get; set; }
       public int CurrentPage { get; set; }
       public int TotalPages
       {
           get
           {
               return (int)Math.Ceiling((decimal)TotalLessons / LessonsPerPage);
           }
       }  
    }
}