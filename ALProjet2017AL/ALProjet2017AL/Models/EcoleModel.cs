using PlanningEsgi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class EcoleModel
    {
        public string name { get; set; }
        public AdresseModel adresse { get; set; }
        public string logoURL { get; set; }
    }
}