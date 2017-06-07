using PlanningEsgi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class PlageHoraireModel
    {
        private SalleModel salle { get; set; }
        private ProfesseurModel professeur { get; set; }
        private ClasseModel classe { get; set; }
    }
}