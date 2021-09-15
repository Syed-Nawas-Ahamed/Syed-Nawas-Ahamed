using System;
using BusinessObjectsBusRes;
using System.Collections.Generic;

namespace DataAccessLayerBusRes
{
    public interface IBusReservationDAL
    {
        public List<Bus> GetBuses();
    }
}
