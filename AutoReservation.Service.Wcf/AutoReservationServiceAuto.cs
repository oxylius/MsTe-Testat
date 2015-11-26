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
        public List<AutoDto> GetAutos
        {
            get {
                WriteActualMethod();

                return autoReservationBusinessComponent.GetAutos().ConvertToDtos();
            }
            
        }

        public AutoDto GetAuto(int autoId)
        {
            WriteActualMethod();

            return autoReservationBusinessComponent.GetAuto(autoId).ConvertToDto();
        }
        public AutoDto InsertAuto(AutoDto autoDto)
        {
            WriteActualMethod();

            Auto auto = autoDto.ConvertToEntity();

            return autoReservationBusinessComponent.Insert(auto).ConvertToDto();
        }

        public AutoDto UpdateAuto(AutoDto modified, AutoDto original)
        {
            WriteActualMethod();

            Auto modAuto = modified.ConvertToEntity();
            Auto origAuto = original.ConvertToEntity();

            return autoReservationBusinessComponent.Update(modAuto, origAuto).ConvertToDto();
        }

        public AutoDto DeleteAuto(AutoDto autoDto)
        {
            WriteActualMethod();

            Auto auto = autoDto.ConvertToEntity();

            return autoReservationBusinessComponent.Delete(auto).ConvertToDto();
        }
        
    }
}