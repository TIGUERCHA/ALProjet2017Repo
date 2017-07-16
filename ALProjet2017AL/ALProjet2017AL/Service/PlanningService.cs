using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ALProjet2017AL.Models;
using ALProjet2017AL.Dal;
using ALProjet2017AL.Views.ViewModels.ReservationHeure;

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
            reservation.DATE = Convert.ToDateTime(model.DATE);

            return reservation;
        }

        public static List<RESERVATION_MODEL> GetAll()
        {
            List<RESERVATIONs> _model = new List<RESERVATIONs>();
            try
            {
                using (unitOfWork unitofwork = new unitOfWork())
                {
                    _model = unitofwork.GetReservationDay.Get().ToList();
                    return mappingResultDbToModel(_model);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<RESERVATION_MODEL> mappingResultDbToModel(List<RESERVATIONs> dbResult)
        {
            List<RESERVATION_MODEL> modelList = new List<RESERVATION_MODEL>();

            foreach (var item in dbResult)
            {
                RESERVATION_MODEL model = new RESERVATION_MODEL();
                model.DATE = item.DATE;
                model.DATE_DEBUT = item.DATE_DEBUT;
                model.DATE_FIN = item.DATE_FIN;
                model.MATIERE = item.MATIERE;
                model.PROFFESSEUR = item.PROFESSEUR;
                model.PROMOTION = item.PROMOTION;
                model.SALLE = item.SALLE;
                modelList.Add(model);
            }
            return modelList;
        }
    }
}