using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ALProjet2017AL.Models;
using ALProjet2017AL.Service;
using ALProjet2017AL.Views.ViewModels.ReservationHeure;

namespace ALProjet2017AL.Controllers
{
    public class PlanningController : Controller
    {
        // GET: Planning
        public ActionResult Index()
        {
            IndexViewModelPlanning model = new IndexViewModelPlanning();
            model = _getPlanning();
            return View(model);
        }

        public ActionResult enregistrer(string promotion, string matiere, string salle, string professeur, string heuredabut, string heurefin)
        {
            string messErreur = null;

            RESERVATION_MODEL reservation = new RESERVATION_MODEL();
            reservation.PROMOTION = promotion;
            reservation.MATIERE = matiere;
            reservation.SALLE = salle;
            reservation.PROFFESSEUR = professeur;
            reservation.DATE_DEBUT = Convert.ToDateTime(heuredabut);
            reservation.DATE_FIN = Convert.ToDateTime(heurefin);

            messErreur = PlanningService.AjouterReservationDansLaBase(reservation);
            //if (messErreur == null)
            //{
              
            //}
            return Content(messErreur, null);
        }

        public ActionResult getPlanning(string selectedDate)
        {
            IndexViewModelPlanning viewmodelReservation = new IndexViewModelPlanning();
            ReservationModels reservationModel = new ReservationModels();
            reservationModel = PlanningService.GetByDay(selectedDate);


            if (reservationModel.reservation.DATE != null)
            {
                //viewmodelReservation.DATE = Convert.ToDateTime(reservationModel.reservation.DATE);
                viewmodelReservation.MATIERE = reservationModel.reservation.MATIERE;
                //ViewData["date"] = reservationModel.reservation.DATE;
            }
            //return Content(reservationModel.ERREUR);
            return View("Index", viewmodelReservation);
        }

        public IndexViewModelPlanning _getPlanning()
        {
            IndexViewModelPlanning viewmodelReservation = new IndexViewModelPlanning();
            ReservationModels reservationModel = new ReservationModels();
            reservationModel = PlanningService.GetByDay("02/07/2017");


            if (reservationModel.reservation.DATE != null)
            {
                //viewmodelReservation.DATE = Convert.ToDateTime(reservationModel.reservation.DATE);
                viewmodelReservation.MATIERE = reservationModel.reservation.MATIERE;
                //ViewData["date"] = reservationModel.reservation.DATE;
            }
            return viewmodelReservation;
        }
    }
}