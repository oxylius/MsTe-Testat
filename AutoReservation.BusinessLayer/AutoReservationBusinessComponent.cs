using System.Collections.Generic;
using AutoReservation.Dal;
using System.Linq;

namespace AutoReservation.BusinessLayer
{
    public class AutoReservationBusinessComponent
    {

        //Autos
        //List<Auto> GetAll()
        public List<Auto> GetAutos()
        {
            using(var context = new AutoReservationEntities())
            {
                return context.Autos.ToList();
            }
        }
        //Auto Get(Id)
        public Auto GetAuto(int id)
        {
            using(var context = new AutoReservationEntities())
            {
                return context.Autos.Find(id);
            }
        }
        //Auto Insert(Auto auto)
        public Auto Insert(Auto auto)
        {
            using(var context = new AutoReservationEntities())
            {
                return context.Autos.Attach(auto);
            }
        }
        //Auto Update(Auto modified, Auto original)
        public Auto Update(Auto modified, Auto original)
        {
            using(var context = new AutoReservationEntities())
            {
                context.Autos.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
                return modified;
            }
        }
        //Auto Delete(Auto)
        public Auto Delete(Auto auto)
        {
            using(var context = new AutoReservationEntities())
            {
                context.Autos.Attach(auto);
                context.Autos.Remove(auto);
                return auto;
            }
        }

        //Kunde
        //List<Kunde> GetAll()
        public List<Kunde> GetKunden()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunden.ToList();
            }
        }
        //Auto Get(Id)
        public Kunde GetKunde(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunden.Find(id);
            }
        }
        //Kunde Insert(Kunde kunde)
        public Kunde Insert(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunden.Attach(kunde);
            }
        }
        //Kunde Update(Kunde modified, Kunde original)
        public Kunde Update(Kunde modified, Kunde original)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunden.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
                return modified;
            }
        }
        //Kunde Delete(Kunde)
        public Kunde Delete(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunden.Attach(kunde);
                context.Kunden.Remove(kunde);
                return kunde;
            }
        }

        //Reservation
        //List<Reservation> GetAll()
        public List<Reservation> GetReservationen()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.ToList();
            }
        }
        //Reservation Get(Id)
        public Reservation Get(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.Find(id);
            }
        }
        //Reservation Insert(Reservation reservation)
        public Reservation Insert(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.Attach(reservation);
            }
        }
        //Reservation Update(Reservation modified, Reservation original)
        public Reservation Update(Reservation modified, Reservation original)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Attach(original);
                context.Entry(original).CurrentValues.SetValues(modified);
                return modified;
            }
        }
        //Reservation Delete(Reservation reservation)
        public Reservation Delete(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Attach(reservation);
                context.Reservationen.Remove(reservation);
                return reservation;
            }
        }

        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }
    }
}