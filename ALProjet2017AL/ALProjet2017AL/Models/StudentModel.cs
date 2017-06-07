using ALProjet2017AL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanningEsgi.Models
{
    public class EtudiantModel
    {
        private string Prenom { get; set; }
        private string Nom { get; set; }
        private DateTime date_naissance { get; set; }
        private ClasseModel classe { get; set; }
    }
}