using ALProjet2017AL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALProjet2017AL.Controllers
{
    public class DailyPlanningController : Controller
    {
        // GET: DailyPlanning
        public ActionResult DayPlanning(DayModel dayConcerned)
        {
            return View(dayConcerned);
        }
    }
}