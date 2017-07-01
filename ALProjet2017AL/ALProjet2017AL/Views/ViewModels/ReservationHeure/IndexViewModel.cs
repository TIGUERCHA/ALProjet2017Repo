using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Views.ViewModels.ReservationHeure
{
    [Serializable]
    public class IndexViewModel
    {
        public string PROMOTION { get; set; }
        public string MATIERE { get; set; }
        public DateTime DATE { get; set; }
        public DateTime HEURE_DEBUT { get; set; }
        public DateTime HEURE_FIN { get; set; }
        public string SALLE { get; set; }
        public string PROFFESSEUR { get; set; }
    }
}