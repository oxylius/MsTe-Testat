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
        List<AutoDto> GetAutos
        {
            [OperationContract]
            get;
        }

        [OperationContract]
        AutoDto GetAuto(int primaryKey);
        [OperationContract]
        AutoDto InsertAuto(AutoDto dto);
        [OperationContract]
        [FaultContract(typeof(AutoDto))]
        AutoDto UpdateAuto(AutoDto modified, AutoDto original);
        [OperationContract]
        AutoDto DeleteAuto(AutoDto dto);
    }
}
