using AutoReservation.BusinessLayer;
using System;
using System.Diagnostics;

namespace AutoReservation.Service.Wcf
{
    public class AutoReservationService
    {
        AutoReservationBusinessComponent db = new AutoReservationBusinessComponent();


        private static void WriteActualMethod()
        {
            Console.WriteLine("Calling: " + new StackTrace().GetFrame(1).GetMethod().Name);
        }
    }
}