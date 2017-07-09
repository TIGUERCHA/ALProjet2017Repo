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
        [HttpPost]
        public ActionResult RadioButtonChoice(string TypePlanning, string DateChosen)
        {
            string[] dateSplit = DateChosen.Split('/');
            DayModel dayChosen = new DayModel(dateSplit[0], dateSplit[1], dateSplit[2]);
            makeDummyPlageHoraire(dayChosen);

            if (TypePlanning.Equals("day"))
            {
                // You cannot pass complex objects in an url like that.
                // You will have to send its constituent parts:
                /*
                 * 
                 * return RedirectToAction("action2", new { 
                       id = user.Id, 
                       firstName = user.FirstName, 
                       lastName = user.LastName, 
                       ...
                   });
                 * 
                 * Le truc serait de passer l'id pour la BDD => retrieveDataFromDatabase(tableName, Id)
                 * Pour un jour: jjmmyyyypromotion
                 */

                return RedirectToAction("DayPlanning", "DailyPlanning", new { dayConcerned = dayChosen });
            }
            else if(TypePlanning.Equals("week"))
            {
                return RedirectToAction("WeekPlanning", "WeeklyPlanning");
            }
            return RedirectToAction("NotFound", "NotFound");
        }

        void makeDummyPlageHoraire(DayModel dummyDay)
        {


            // Full dummy test every 15 min
            // 8h - 20h
            for (int i = 8; i <= 20; i++)
            {
                var uniqueProf = new ProfesseurModel("Mr", "teleportation");
                var badLuckClass = new ClasseModel("AL13");
                var a = new PlageHoraireModel();
                a.salle = new SalleModel("A01");
                a.professeur = uniqueProf;
                a.professeur = uniqueProf;
                a.classe = badLuckClass;
                a.jour = dummyDay;
                var b = new PlageHoraireModel();
                b.salle = new SalleModel("A02");
                b.professeur = uniqueProf;
                b.classe = badLuckClass;
                b.jour = dummyDay;
                var c = new PlageHoraireModel();
                c.salle = new SalleModel("B01");
                c.professeur = uniqueProf;
                c.classe = badLuckClass;
                c.jour = dummyDay;
                var d = new PlageHoraireModel();
                d.salle = new SalleModel("C01");
                d.professeur = uniqueProf;
                d.classe = badLuckClass;
                d.jour = dummyDay;
            }
        }

    }

}