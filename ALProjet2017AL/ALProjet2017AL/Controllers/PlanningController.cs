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
            List<IndexViewModelPlanning> ListViewModel = new List<IndexViewModelPlanning>();
            ReservationListeModel listModel = new ReservationListeModel();
            ListViewModel = initModelPlanning();
            listModel.Reservations = ListViewModel.ToList();
            return View(listModel);
        }

        public ActionResult enregistrer(string promotion, string matiere, string salle, string professeur, string heuredabut, string heurefin, string date)
        {
            string messErreur = null;

            RESERVATION_MODEL reservation = new RESERVATION_MODEL();
            reservation.PROMOTION = promotion;
            reservation.MATIERE = matiere;
            reservation.SALLE = salle;
            reservation.PROFFESSEUR = professeur;
            reservation.DATE_DEBUT = Convert.ToDateTime(heuredabut);
            reservation.DATE_FIN = Convert.ToDateTime(heurefin);
            reservation.DATE = Convert.ToDateTime(date);

            messErreur = PlanningService.AjouterReservationDansLaBase(reservation);
            //if (messErreur == null)
            //{
              
            //}
            return Content(messErreur, null);
        }

        public ActionResult getPlanning(string selectedDate)
        {
            List<IndexViewModelPlanning> ListViewModel = new List<IndexViewModelPlanning>();
            List<IndexViewModelPlanning> ListViewModelFiltrer = new List<IndexViewModelPlanning>();
            ReservationListeModel listModel = new ReservationListeModel();
            ListViewModel = initModelPlanning();
            foreach (var item in ListViewModel)
            {
                if (item.DATE == Convert.ToDateTime(selectedDate))
                {
                    ListViewModelFiltrer.Add(item);
                }
            }
            listModel.Reservations = ListViewModelFiltrer.ToList();
            //return View();
            return PartialView("_ConsultationPlanning", listModel);//, viewmodelReservation
        }

        public List<IndexViewModelPlanning> initModelPlanning()
        {
            InitdropDownList();
            List<RESERVATION_MODEL> listReservationModel = new List<RESERVATION_MODEL>();

            List<IndexViewModelPlanning> viewmodelReservation = new List<IndexViewModelPlanning>();
            listReservationModel = PlanningService.GetAll();
            viewmodelReservation = mappingModelViewModel(listReservationModel);
           
            return viewmodelReservation;
        }

        private void InitdropDownList()
        {
            ViewBag.PromotionList = new SelectList(GetPromotionList(), "Key", "Value");
            ViewBag.MatiereList = new SelectList(GetMatiereList(), "Key", "Value");
            ViewBag.SalleList = new SelectList(GetSalleList(), "Key", "Value");
            ViewBag.ProfList = new SelectList(GetProfList(), "Key", "Value");
        }

        public static Dictionary<string, string> GetPromotionList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            List<PROMOTION> listePromo = ElementListService.GetPromotion();
            dictionary.Add("0", "--");
            foreach (PROMOTION promo in listePromo)
            {
                dictionary.Add((string)promo.nom_specialite, promo.nom_specialite);
            }

            return dictionary;
        }

        public static Dictionary<string, string> GetMatiereList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            List<MATIERE> listeMatiere = ElementListService.GetMatiere();
            dictionary.Add("0", "--");
            foreach (MATIERE matiere in listeMatiere)
            {
                dictionary.Add((string)matiere.LIBELLE, matiere.LIBELLE);
            }

            return dictionary;
        }

        public static Dictionary<string, string> GetSalleList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            List<SALLE> listeSalle = ElementListService.GetSalle();
            dictionary.Add("0", "--");
            foreach (SALLE salle in listeSalle)
            {
                dictionary.Add((string)salle.nom_salle, salle.nom_salle);
            }

            return dictionary;
        }

        public static Dictionary<string, string> GetProfList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            List<PROFESSEUR> listeProf = ElementListService.GetfProfesseur();
            dictionary.Add("0", "--");
            foreach (PROFESSEUR prof in listeProf)
            {
                dictionary.Add((string)prof.NOM, prof.NOM);
            }

            return dictionary;
        }

        public static List<IndexViewModelPlanning> mappingModelViewModel(List<RESERVATION_MODEL> listReservationModel)
        {
            List<IndexViewModelPlanning> listviewmodelReservation = new List<IndexViewModelPlanning>();
            foreach (var item in listReservationModel)
            {
                IndexViewModelPlanning viewModelReservation = new IndexViewModelPlanning();
                viewModelReservation.DATE = item.DATE;
                viewModelReservation.HEURE_DEBUT = item.DATE_DEBUT;
                viewModelReservation.HEURE_FIN = item.DATE_FIN;
                viewModelReservation.MATIERE = item.MATIERE;
                viewModelReservation.PROFFESSEUR = item.PROFFESSEUR;
                viewModelReservation.PROMOTION = item.PROMOTION;
                viewModelReservation.SALLE = item.SALLE;
                listviewmodelReservation.Add(viewModelReservation);
            }
            return listviewmodelReservation;
        }
    }
}