using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ALProjet2017AL.Models;
using ALProjet2017AL.Dal;

namespace ALProjet2017AL.Service
{
    public class ConnexionService
    {

        public static UTILISATEUR_MODEL GetUserPasswordByEmail(string email)
        {
            List<UTILISATEUR> _model = new List<UTILISATEUR>();
            try
            {
                using (unitOfWork unitofwork = new unitOfWork())
                {
                    _model = unitofwork.GetUser.Get(x => x.E_MAIL == email).ToList();
                    return mappingResultDbToModel(_model);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static UTILISATEUR_MODEL mappingResultDbToModel(List<UTILISATEUR> model)
        {
            UTILISATEUR_MODEL _model = new UTILISATEUR_MODEL();
            
            _model.ID = model[0].ID;
            _model.NOM = model[0].NOM;
            _model.PRENOM = model[0].PRENOM;
            _model.E_MAIL = model[0].E_MAIL;
            _model.PASSWORD = model[0].PASSWORD;
            _model.STATUT = model[0].STATUT;

            return _model;
        }
    }
}