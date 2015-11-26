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
        public List<KundeDto> GetKunden
        {
            get
            {
                WriteActualMethod();

                return autoReservationBusinessComponent.GetKunden().ConvertToDtos();
            }
        }

        public KundeDto GetKunde(int kundeId)
        {
            WriteActualMethod();

            return autoReservationBusinessComponent.GetKunde(kundeId).ConvertToDto();
        }
        public KundeDto InsertKunde(KundeDto kundeDto)
        {
            WriteActualMethod();

            Kunde Kunde = kundeDto.ConvertToEntity();

            return autoReservationBusinessComponent.Insert(Kunde).ConvertToDto();
        }

        public KundeDto UpdateKunde(KundeDto modified, KundeDto original)
        {
            WriteActualMethod();

            Kunde modKunde = modified.ConvertToEntity();
            Kunde origKunde = original.ConvertToEntity();

            return autoReservationBusinessComponent.Update(modKunde, origKunde).ConvertToDto();
        }

        public KundeDto DeleteKunde(KundeDto kundeDto)
        {
            WriteActualMethod();

            Kunde kunde = kundeDto.ConvertToEntity();

            return autoReservationBusinessComponent.Delete(kunde).ConvertToDto();
        }
        
    }
}