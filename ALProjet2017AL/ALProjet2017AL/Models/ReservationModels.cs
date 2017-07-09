using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class ReservationModels
    {
        public RESERVATIONs reservation { get; set; }
        public string ERREUR { get; set; }
    }

    public class RESERVATION_LIST_MODEL
    {
        public List<RESERVATION_MODEL> Reservations { get; set; }
        public string ERREUR { get; set; }
    }

    public class RESERVATION_MODEL
    {
        public string PROMOTION { get; set; }
        public string MATIERE { get; set; }
        public string SALLE { get; set; }
        public string PROFFESSEUR { get; set; }
        public DateTime DATE_DEBUT { get; set; }
        public DateTime DATE_FIN { get; set; }
        public DateTime DATE { get; set; }
    }
}