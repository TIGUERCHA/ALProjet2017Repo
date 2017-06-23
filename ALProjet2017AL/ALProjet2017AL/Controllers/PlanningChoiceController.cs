using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALProjet2017AL.Controllers
{
    public class PlanningChoiceController : Controller
    {
        [HttpPost]
        public ActionResult RadioButtonChoice(string TypePlanning)
        {
            Console.Write("...");
            if (TypePlanning.Equals("day"))
            {

            }
            else if(TypePlanning.Equals("week"))
            {
                Console.Write("TARASSE");
                return RedirectToAction("WeekPlanning", "WeeklyPlanning");
            }
            return RedirectToAction("NotFound", "NotFound");
        }

    }
}