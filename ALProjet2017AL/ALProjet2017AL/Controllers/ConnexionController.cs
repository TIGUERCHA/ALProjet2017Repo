using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ALProjet2017AL.Models;
using ALProjet2017AL.Service;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace ALProjet2017AL.Controllers
{
    public class ConnexionController : Controller
    {
        public static UTILISATEUR _user { get; set; }
        public static Boolean LoginExecutable { get; set; }
        // GET: Connexion
        public ActionResult Index()
        {
            return View();
        }

        public UTILISATEUR GetSessionUser()
        {
            UTILISATEUR User = new UTILISATEUR();

            User.E_MAIL = GetUserEmail();
            User.NOM = GetUserNom();
            User.PRENOM = GetUserPrenom();
            User.STATUT = GetUserStatut();
            _user = User;
            return _user;
        }

        public ActionResult CheckLogin(string email, string password)
        {
            //string messErreur = null;

            UTILISATEUR_MODEL utilisateur = new UTILISATEUR_MODEL();
            utilisateur = ConnexionService.GetUserPasswordByEmail(email);
            if (utilisateur == null)
            {
                return Content("ko", null);
            }
            if (utilisateur.PASSWORD == EncryptString(password))
            {
                SetUserEmail(utilisateur.E_MAIL);
                SetUserNom(utilisateur.NOM);
                SetUserPrenom(utilisateur.PRENOM);
                SetUserStatut(utilisateur.STATUT);
                return Content(utilisateur.STATUT, null);
            }
            else
            {
                return Content("ko", null);
            }
            //if (messErreur == null)
            //{

            //}
        }

        [HttpGet]
        public JsonResult GetInfoUser()
        {
            UTILISATEUR user = new UTILISATEUR();
            user = GetSessionUser();
            if (user.E_MAIL == null)
            {
                user = null;
            }
            
            if (user != null)
            {

                return Json(new
                {
                    email = user.E_MAIL,
                    statut = user.STATUT,
                },
                    JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    email = "",
                    statut = "",
                },
                    JsonRequestBehavior.AllowGet);
            }
        }

        [AllowAnonymous]
        public ActionResult LogOut()
        {
            SetUserEmail("");
            SetUserNom("");
            SetUserPrenom("");
            SetUserStatut("");
            LoginExecutable = false;
            return RedirectToAction("Index", "Home");
        }

        public static string EncryptString(string clearText)
        {

            string strKey = "9FE59A376A87D5E6";
            string strIv = "9FE59A376A87D5E6";
            // Place le texte à chiffrer dans un tableau d'octets
            byte[] plainText = Encoding.UTF8.GetBytes(clearText);

            // Place la clé de chiffrement dans un tableau d'octets
            byte[] key = Encoding.UTF8.GetBytes(strKey);

            // Place le vecteur d'initialisation dans un tableau d'octets
            byte[] iv = Encoding.UTF8.GetBytes(strIv);


            RijndaelManaged rijndael = new RijndaelManaged();

            // Définit le mode utilisé
            rijndael.Mode = CipherMode.CBC;

            // Crée le chiffreur AES - Rijndael
            ICryptoTransform aesEncryptor = rijndael.CreateEncryptor(key, iv);

            MemoryStream ms = new MemoryStream();

            // Ecris les données chiffrées dans le MemoryStream
            CryptoStream cs = new CryptoStream(ms, aesEncryptor, CryptoStreamMode.Write);
            cs.Write(plainText, 0, plainText.Length);
            cs.FlushFinalBlock();


            // Place les données chiffrées dans un tableau d'octet
            byte[] CipherBytes = ms.ToArray();


            ms.Close();
            cs.Close();

            // Place les données chiffrées dans une chaine encodée en Base64
            return Convert.ToBase64String(CipherBytes);
            //return Convert.ToInt64(CipherBytes);
        }

        #region Session variables

        public void SetUserEmail(string Email)
        {
            Session["UserEmail"] = Email;
        }

        public string GetUserEmail()
        {
            string _userEmail = null;
            
            if (Session != null && Session["UserEmail"] != null)
            {
                _userEmail = Session["UserEmail"].ToString();
            }
            return _userEmail;
        }

        public void SetUserStatut(string Statut)
        {
            Session["UserStatut"] = Statut;
        }

        public string GetUserStatut()
        {
            string _userStatut = null;
            if (Session != null && Session["UserStatut"] != null)
            {
                _userStatut = Session["UserStatut"].ToString();
            }
            return _userStatut;
        }

        public void SetUserNom(string Nom)
        {
            Session["UserNom"] = Nom;
        }

        public string GetUserNom()
        {
            string _userNom = null;
            if (Session != null && Session["UserNom"] != null)
            {
                _userNom = Session["UserNom"].ToString();
            }
            return _userNom;
        }

        public void SetUserPrenom(string Prenom)
        {
            Session["UserPrenom"] = Prenom;
        }

        public string GetUserPrenom()
        {
            string _userPrenom = null;
            if (Session != null && Session["UserPrenom"] != null)
            {
                _userPrenom = Session["UserPrenom"].ToString();
            }
            return _userPrenom;
        }

        #endregion
    }
}