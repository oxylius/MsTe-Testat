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
        //Autos
        //List<Auto> GetAll()
        public List<Auto> GetAutos()
        {
            using (var context = new AutoReservationEntities())
            { 
                return context.Autos.ToList();
            }
        }
        //Auto Get(Id)
        public Auto GetAuto(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Autos.Find(id);
            }
        }
        //Auto Insert(Auto auto)
        public Auto Insert(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Autos.Attach(auto);
            }
        }
        //Auto Update(Auto modified, Auto original)
        public Auto Update(Auto modified, Auto original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Autos.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    return modified;
                }
               
                 catch (DbUpdateConcurrencyException e)
                {
                    HandleDbConcurrencyException<Auto>(context, original);
                    return null;
                }
            }
        }
        //Auto Delete(Auto)
        public Auto Delete(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Autos.Attach(auto);
                context.Autos.Remove(auto);
                return auto;
            }
        }
    }
}
