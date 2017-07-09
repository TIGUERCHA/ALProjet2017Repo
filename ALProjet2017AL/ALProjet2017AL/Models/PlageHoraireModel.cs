using PlanningEsgi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class PlageHoraireModel
    {

        public PlageHoraireModel()
        {

        }

        public int heureDebut { get; set; }
        public int heureFin { get; set; }
        public DayModel jour { get; set; }
        public SalleModel salle { get; set; }
        public ProfesseurModel professeur { get; set; }
        public ClasseModel classe { get; set; }

        /**
         * Un id est constitué de
         * La date, la classe et les horaires
         * 
         * Exemple:
         * 
         * Le 21/03/2016
         * Classe: 4AL
         * Horaires: 8h00 - 13h00
         * 
         * Id : 210320164AL08001300
         * (Soit:21 03 2016 4AL 0800 1300)
         */
        public String makeId()
        {
            return jour.day
                + jour.month
                + jour.year
                + classe.promotion
                + heureDebut
                + heureFin;
        }
    }
}