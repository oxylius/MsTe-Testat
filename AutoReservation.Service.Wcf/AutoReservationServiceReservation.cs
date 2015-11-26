using AutoReservation.BusinessLayer;
using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Dal;

namespace AutoReservation.Service.Wcf
{
    public partial class AutoReservationService : IAutoReservationService
    {
        public List<ReservationDto> GetReservationen
        {
            get
            {
                WriteActualMethod();

                return autoReservationBusinessComponent.GetReservationen().ConvertToDtos();
            }
            
        }

        public ReservationDto GetReservation(int reservationId)
        {
            WriteActualMethod();

            return autoReservationBusinessComponent.GetReservation(reservationId).ConvertToDto();
        }
        public ReservationDto InsertReservation(ReservationDto reservationDto)
        {
            WriteActualMethod();

            Reservation reservation = reservationDto.ConvertToEntity();

            return autoReservationBusinessComponent.Insert(reservation).ConvertToDto();
        }

        public ReservationDto UpdateReservation(ReservationDto modified, ReservationDto original)
        {
            WriteActualMethod();

            Reservation modReservation = modified.ConvertToEntity();
            Reservation origReservation = original.ConvertToEntity();

            return autoReservationBusinessComponent.Update(modReservation, origReservation).ConvertToDto();
        }

        public ReservationDto DeleteReservation(ReservationDto reservationDto)
        {
            WriteActualMethod();

            Reservation reservation = reservationDto.ConvertToEntity();

            return autoReservationBusinessComponent.Delete(reservation).ConvertToDto();
        }
        
    }
}