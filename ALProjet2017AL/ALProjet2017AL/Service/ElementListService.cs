using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ALProjet2017AL.Dal;

namespace ALProjet2017AL.Service
{
    public class ElementListService
    {
        public static List<PROMOTION> GetPromotion()
        {
            try
            {
                using ( unitOfWork unitofwork = new unitOfWork())
                {
                    return unitofwork.GetPromotion.Get().ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<MATIERE> GetMatiere()
        {
            try
            {
                using (unitOfWork unitofwork = new unitOfWork())
                {
                    return unitofwork.GetMatiere.Get().ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<SALLE> GetSalle()
        {
            try
            {
                using (unitOfWork unitofwork = new unitOfWork())
                {
                    return unitofwork.GetSalle.Get().ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<PROFESSEUR> GetfProfesseur()
        {
            try
            {
                using (unitOfWork unitofwork = new unitOfWork())
                {
                    return unitofwork.GetProf.Get().ToList();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}