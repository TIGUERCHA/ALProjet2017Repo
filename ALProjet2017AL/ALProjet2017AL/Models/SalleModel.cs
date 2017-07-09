using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanningEsgi.Models
{
    public class SalleModel
    {
        public string Nom_salle { get; set; }
        
        public SalleModel(string nom)
        {
            Nom_salle = nom;
        }
    }
}