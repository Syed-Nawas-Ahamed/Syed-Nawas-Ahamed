using BusinessObjectsBusRes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBusRes
{
    class BusReservationDAL : IBusReservationDAL
    {
        public List<Bus> GetBuses()
        {
            return new List<Bus>() {
            
                new Bus()
                {
                    BusNumber = "KTHYCH001",
                    BusName = "Kesineni Travels",
                    Source= "Hyderabad",
                    Destination= "Chennai"
                },
                new Bus()
                {
                    BusNumber = "SRSBGCH001",
                    BusName = "SRS Travels",
                    Source= "Bangalore",
                    Destination= "Chennai"
                }
            };
        }
    }
}
