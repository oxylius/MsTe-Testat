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
                try
                {
                    context.Kunden.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    return modified;
                }
                catch (DbUpdateConcurrencyException e)
                {
                    HandleDbConcurrencyException<Kunde>(context, original);
                    return null;
                }
                

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
    }
}
