using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ALProjet2017AL.Models;
using ALProjet2017AL.Dal;

namespace ALProjet2017AL.Service
{
    public class PlanningService
    {
        public static string AjouterReservationDansLaBase(RESERVATION_MODEL model)
        {
            RESERVATIONs reservation = IntReservationFromModel(model);
            using (unitOfWork unitOfWork = new unitOfWork())
            {
                return unitOfWork.ReservationRepository.Add(reservation);
            }
        }

        public static RESERVATIONs IntReservationFromModel(RESERVATION_MODEL model)
        {
            RESERVATIONs reservation = new RESERVATIONs();
            reservation.PROMOTION = model.PROMOTION;
            reservation.MATIERE = model.MATIERE;
            reservation.SALLE = model.SALLE;
            reservation.PROFESSEUR = model.PROFFESSEUR;
            reservation.DATE_DEBUT = Convert.ToDateTime(model.DATE_DEBUT);
            reservation.DATE_FIN = Convert.ToDateTime(model.DATE_FIN);
            reservation.DATE = Convert.ToDateTime("03/07/2017");

            return reservation;
        }

        public static ReservationModels GetByDay(string dateNow)
        {
            DateTime date = Convert.ToDateTime(dateNow);
            ReservationModels _model = new ReservationModels();

            try
            {
                using (unitOfWork unitofwork = new unitOfWork())
                {
                    _model.reservation = unitofwork.GetReservationDay.Get(p => p.DATE == date).FirstOrDefault();
                    _model.ERREUR = null;

                    return _model;
                }
            }
            catch (Exception e)
            {
                _model.reservation = null;
                _model.ERREUR = e.Message;

                return _model;
            }
        }
    }
}