using PlanningEsgi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class EtudiantModel
    {
        public string prenom { get; set; }
        public string nom { get; set; }
        public DateTime date_naissance { get; set; }
        public ClasseModel classe { get; set; }
        public AdresseModel adresse { get; set; }
    }
}