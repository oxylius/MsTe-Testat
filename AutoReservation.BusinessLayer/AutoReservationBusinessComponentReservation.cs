using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoReservation.Dal;

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
    }
}
