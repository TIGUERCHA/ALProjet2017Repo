using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Views.ViewModels.ReservationHeure
{
    [Serializable]
    public class IndexViewModelPlanning
    {
        public string PROMOTION { get; set; }
        public string MATIERE { get; set; }
        public DateTime DATE { get; set; }
        public DateTime HEURE_DEBUT { get; set; }
        public DateTime HEURE_FIN { get; set; }
        public string SALLE { get; set; }
        public string PROFFESSEUR { get; set; }
    }

    //public class ReservationListeModel
    //{
    //    public List<IndexViewModel> Reservations { get; set; }
    //    public string ERREUR { get; set; }
    //}
}