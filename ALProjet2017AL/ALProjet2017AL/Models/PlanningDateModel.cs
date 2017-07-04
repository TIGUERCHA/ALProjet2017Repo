using ALProjet2017AL.Models.enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class PlanningDateModel
    {
        public PlanningType type { get; set; }
        public DayModel dayConcerned { get; set; }
        public PlanningDateModel(string day, string month, string year)
        {
            //this.dayConcerned = findDayModel(day, month, year);
        }
    }
}