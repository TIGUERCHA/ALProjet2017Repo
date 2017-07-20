using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALProjet2017AL.Dal
{
    public class unitOfWork : IDisposable
    {
        private CalendrierESGIEntities context = new CalendrierESGIEntities();
        private GenericRepository<RESERVATIONs> reservationRepository;
        private GenericRepository<RESERVATIONs> getReservationDay;
        private GenericRepository<PROMOTION> getPromotion;
        private GenericRepository<MATIERE> getMatiere;
        private GenericRepository<SALLE> getSalle;
        private GenericRepository<PROFESSEUR> getProf;
        private GenericRepository<UTILISATEUR> getUser;
        public GenericRepository<RESERVATIONs> ReservationRepository
        {
            get
            {
                if (this.reservationRepository ==null)
                {
                    this.reservationRepository = new GenericRepository<RESERVATIONs>(context);
                }
                return reservationRepository;
            }
        }

        public GenericRepository<RESERVATIONs> GetReservationDay
        {
            get
            {
                if (this.getReservationDay == null)
                {
                    this.getReservationDay = new GenericRepository<RESERVATIONs>(context);
                }
                return getReservationDay;
            }
        }

        public GenericRepository<PROMOTION> GetPromotion
        {
            get
            {
                if (this.getPromotion == null)
                {
                    this.getPromotion = new GenericRepository<PROMOTION>(context);
                }
                return getPromotion;
            }
        }

        public GenericRepository<MATIERE> GetMatiere
        {
            get
            {
                if (this.getMatiere == null)
                {
                    this.getMatiere = new GenericRepository<MATIERE>(context);
                }
                return getMatiere;
            }
        }

        public GenericRepository<SALLE> GetSalle
        {
            get
            {
                if (this.getSalle == null)
                {
                    this.getSalle = new GenericRepository<SALLE>(context);
                }
                return getSalle;
            }
        }

        public GenericRepository<PROFESSEUR> GetProf
        {
            get
            {
                if (this.getProf == null)
                {
                    this.getProf = new GenericRepository<PROFESSEUR>(context);
                }
                return getProf;
            }
        }

        public GenericRepository<UTILISATEUR> GetUser
        {
            get
            {
                if (this.getUser == null)
                {
                    this.getUser = new GenericRepository<UTILISATEUR>(context);
                }
                return getUser;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}