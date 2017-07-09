using ALProjet2017AL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanningEsgi.Models
{
    public class EtudiantModel
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime date_naissance { get; set; }
        public ClasseModel classe { get; set; }
    }
}