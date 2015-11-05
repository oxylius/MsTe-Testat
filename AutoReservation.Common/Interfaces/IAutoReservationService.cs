using AutoReservation.Common.DataTransferObjects.Core;
using System.Collections.Generic;

namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService<T>
        where T : DtoBase<T>
    {
        List<DtoBase<T>> getAll();
        T get(int primaryKey);
        void put(T dto);
        void update(T modified, T original);
        void delete(T dto);
    }
}
