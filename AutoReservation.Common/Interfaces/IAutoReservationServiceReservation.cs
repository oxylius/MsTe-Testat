using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Common.DataTransferObjects.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AutoReservation.Common.Interfaces
{
    public partial interface IAutoReservationService
    {
        List<ReservationDto> GetReservationen
        {
            [OperationContract]
            get;
        }
        [OperationContract]
        ReservationDto GetReservation(int primaryKey);
        [OperationContract]
        ReservationDto InsertReservation(ReservationDto dto);
        [OperationContract]
        [FaultContract(typeof(AutoDto))]
        ReservationDto UpdateReservation(ReservationDto modified, ReservationDto original);
        [OperationContract]
        ReservationDto DeleteReservation(ReservationDto dto);
    }
}
