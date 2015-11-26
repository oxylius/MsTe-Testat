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
        List<KundeDto> GetKunden
        {
            [OperationContract]
            get;
        }
        [OperationContract]
        KundeDto GetKunde(int primaryKey);
        [OperationContract]
        KundeDto InsertKunde(KundeDto dto);
        [OperationContract]
        [FaultContract(typeof(AutoDto))]
        KundeDto UpdateKunde(KundeDto modified, KundeDto original);
        [OperationContract]
        KundeDto DeleteKunde(KundeDto dto);
    }
}
