using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Models
{
    public class UtilisateurModel
    {
        public UTILISATEUR utilisateur { get; set; }
        public string ERREUR { get; set; }
    }

    public class UTILISATEUR_MODEL
    {
        public int ID { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string E_MAIL { get; set; }
        public string STATUT { get; set; }
        public string PASSWORD { get; set; }
    }

}