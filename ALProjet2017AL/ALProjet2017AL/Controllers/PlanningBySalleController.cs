using ALProjet2017AL.Models;
using ALProjet2017AL.Views.ViewModels.ReservationHeure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ALProjet2017AL.Service;

namespace ALProjet2017AL.Controllers
{
    public class PlanningBySalleController : Controller
    {
        // GET: PlanningBySalle
        public ActionResult Index(string date, string salle)
        {
            ReservationListeModel listModelIndex = new ReservationListeModel();
            listModelIndex = getPlanningBySalle(date, salle);
            return View(listModelIndex);
        }

        public ReservationListeModel getPlanningBySalle(string date, string salle)
        {
            List<IndexViewModelPlanning> ListViewModel = new List<IndexViewModelPlanning>();
            List<IndexViewModelPlanning> ListViewModelFiltrer = new List<IndexViewModelPlanning>();
            ReservationListeModel listModel = new ReservationListeModel();
            ListViewModel = initModelPlanning(date, salle);
            foreach (var item in ListViewModel)
            {
                if (item.DATE == Convert.ToDateTime(date) && item.SALLE.Split('*')[0]== salle)
                {
                    ListViewModelFiltrer.Add(item);
                }
            }
            listModel.Reservations = ListViewModelFiltrer.ToList();
            //return View();
            return listModel;//, viewmodelReservation
        }

        public List<IndexViewModelPlanning> initModelPlanning(string date, string salle)
        {
            
            List<RESERVATION_MODEL> listReservationModel = new List<RESERVATION_MODEL>();

            List<IndexViewModelPlanning> viewmodelReservation = new List<IndexViewModelPlanning>();
            listReservationModel = PlanningService.GetAll();
            viewmodelReservation = PlanningService.mappingModelViewModel(listReservationModel);

            return viewmodelReservation;
        }
    }
}