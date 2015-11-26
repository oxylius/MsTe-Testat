using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoReservation.Dal;
using System.Data.Entity.Infrastructure;

namespace AutoReservation.BusinessLayer
{
    public partial class AutoReservationBusinessComponent
    {
        //Reservation
        //List<Reservation> GetAll()
        public List<Reservation> GetReservationen()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.Include("Auto").Include("Kunde").ToList();
            }
        }
        //Reservation Get(Id)
        public Reservation GetReservation(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.Include("Auto").Include("Kunde").ToList().Find(i => i.ReservationNr == id);
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
                try
                {
                    context.Reservationen.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    return modified;
                }
                

                catch (DbUpdateConcurrencyException e)
                {
                    HandleDbConcurrencyException<Reservation>(context, original);
                    return null;
                }
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
    }
}
