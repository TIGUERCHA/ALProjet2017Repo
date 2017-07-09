using ALProjet2017AL.Models;
using PlanningEsgi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALProjet2017AL.Controllers
{
    public class PlanningChoiceController : Controller
    {
        //[HttpPost]
        //public ActionResult RadioButtonChoice(string TypePlanning, string DateChosen)
        //{
        //    string[] dateSplit = DateChosen.Split('/');
        //    DayModel dayChosen = new DayModel(dateSplit[0], dateSplit[1], dateSplit[2]);
        //    makeDummyPlageHoraire(dayChosen);

        //    if (TypePlanning.Equals("day"))
        //    {
        //        return RedirectToAction("DayPlanning", "DailyPlanning");
        //    }
        //    else if(TypePlanning.Equals("week"))
        //    {
        //        return RedirectToAction("WeekPlanning", "WeeklyPlanning");
        //    }
        //    return RedirectToAction("NotFound", "NotFound");
        //}

        //void makeDummyPlageHoraire(DayModel dummyDay)
        //{
        //    // Full dummy test every 15 min
        //    // 8h - 20h
        //    for (int i = 8; i <= 20; i++)
        //    {
        //        var a = new PlageHoraireModel();
        //        a.salle = new SalleModel("A01");
        //        dummyDay.plagesHoraireDuJour.Add(a);
        //        var b = new PlageHoraireModel();
        //        b.salle = new SalleModel("A02");
        //        dummyDay.plagesHoraireDuJour.Add(b);
        //        var c = new PlageHoraireModel();
        //        c.salle = new SalleModel("B01");
        //        dummyDay.plagesHoraireDuJour.Add(c);
        //        var d = new PlageHoraireModel();
        //        d.salle = new SalleModel("C01");
        //        dummyDay.plagesHoraireDuJour.Add(d);
        //    }
        //}

    }

}