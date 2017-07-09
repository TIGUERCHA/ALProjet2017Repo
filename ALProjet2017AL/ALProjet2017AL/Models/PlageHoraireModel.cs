using PlanningEsgi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class PlageHoraireModel
    {
        public SalleModel salle { get; set; }
        public ProfesseurModel professeur { get; set; }
        public ClasseModel classe { get; set; }
    }
}