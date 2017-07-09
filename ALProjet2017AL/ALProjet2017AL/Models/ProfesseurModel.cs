using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class ProfesseurModel
    {
        public string nom { get; set; }
        public string prenom { get; set; }

        public ProfesseurModel(string name, string firstname)
        {
            this.nom = name;
            prenom = firstname;
        }
    }
}