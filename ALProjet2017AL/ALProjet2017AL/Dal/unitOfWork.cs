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